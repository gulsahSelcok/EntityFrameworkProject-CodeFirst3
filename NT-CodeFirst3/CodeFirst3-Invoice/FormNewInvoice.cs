using CodeFirst3_Invoice.Context;
using CodeFirst3_Invoice.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst3_Invoice
{
    public partial class FormNewInvoice : Form
    {
        InvoiceContext db = new InvoiceContext();
        private Customer selectedCustomer;
        private Product selectedProduct;
        private HashSet<InvoiceDetails> invoiceDetails = new HashSet<InvoiceDetails>();
        private int invoiceID;
        private InvoiceDetails selectedInvoiceDetail;

        public FormNewInvoice()
        {
            InitializeComponent();

            InvoiceDetails invoice = db.InvoiceDetails.ToList().LastOrDefault();
            invoiceID = invoice == null ? 1 : invoice.InvoiceID;
            lblInvoiceID.Text = invoiceID.ToString();

        }

        private void ComboFill()
        {
            cbProductName.DisplayMember = "ProductName";
            cbProductName.ValueMember = "ProductID";
            cbProductName.DataSource = db.Products.ToList();

            cbCustomerCity.DisplayMember = "Description";
            cbCustomerCity.ValueMember = "CityID";
            cbCustomerCity.DataSource = db.Cities.ToList();
            cbCustomerCity.Enabled = false;

            cbCustomerCounty.DisplayMember = "Description";
            cbCustomerCounty.ValueMember = "CountyID";
            cbCustomerCounty.DataSource = db.Counties.ToList();
            cbCustomerCounty.Enabled = false;

            cbCustomer.DisplayMember = "CustomerName";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DataSource = db.Customers.ToList();
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedIndex == -1)
                return;

            selectedCustomer = (Customer)cbCustomer.SelectedItem;
            cbCustomerCounty.SelectedItem = selectedCustomer.county;
            cbCustomerCity.SelectedItem = selectedCustomer.county.city;
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (!ProductInputControl())
                return;

            decimal tax = Convert.ToDecimal(tbProductTax.Text);
            int count = (int)nudProductQuantity.Value;
            decimal total = (count * selectedProduct.UnitPrice) + (count * selectedProduct.UnitPrice * tax / 100);

            InvoiceDetails invoice = new InvoiceDetails();
            invoice.InvoiceID = invoiceID;
            invoice.products = selectedProduct;

            InvoiceDetails product = invoiceDetails.FirstOrDefault(x => x.ProductID == selectedProduct.ProductID && x.InvoiceID == invoiceID);
            if (product == null)
            {
                invoice.ProductID = selectedProduct.ProductID;
                invoice.Qantity = count;
            }
            else
            {
                invoice = product;
                invoice.Qantity += count;
            }

            invoice.VATAmount = (int)tax;
            invoice.AmountWithVAT = Convert.ToInt32(selectedProduct.UnitPrice + (selectedProduct.UnitPrice * tax / 100));

            invoiceDetails.Add(invoice);
            ProductInputClear();
        }
        private void ProductInputClear()
        {
            selectedInvoiceDetail = null;
            nudProductQuantity.Value = 1;
            tbProductTax.Text = "";
            dgvNewInvoice.DataSource = invoiceDetails.ToList();
        }
        private bool ProductInputControl()
        {
            if (cbProductName.SelectedItem == null)
                return false;

            if (db.Products.ToList().FirstOrDefault(x => x.ProductID == (int)cbProductName.SelectedValue) == null)
                return false;

            if (nudProductQuantity.Value <= 0)
                return false;

            try
            {
                decimal kdv = Convert.ToDecimal(tbProductTax.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductName.SelectedIndex == -1)
                return;

            selectedProduct = (Product)cbProductName.SelectedItem;
            tbProductUnit.Text = selectedProduct.unit.UnitName;
            tbProductPrice.Text = selectedProduct.UnitPrice.ToString();
        }

        private void dgvNewInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvNewInvoice.CurrentRow == null)
                return;

            selectedInvoiceDetail = (InvoiceDetails)dgvNewInvoice.CurrentRow.DataBoundItem;
            cbProductName.SelectedItem = selectedInvoiceDetail.products;
            tbProductTax.Text = selectedInvoiceDetail.VATAmount.ToString();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (selectedInvoiceDetail == null)
                return;

            DialogResult result = MessageBox.Show($"{selectedInvoiceDetail.products.ProductName} adlı ürünü silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                invoiceDetails.Remove(selectedInvoiceDetail);
                ProductInputClear();
            }
        }

        private void btnInvoiceAdd_Click(object sender, EventArgs e)
        {
            if (!ProductInputControl())
                return;

            InvoiceHeader invoiceHeader = new InvoiceHeader()
            {
                InvoiceID = invoiceID,
                invoiceDetails = invoiceDetails,
                InvoiceDate = DateTime.Now,
                DeliveryNote = Convert.ToInt32(tbWaybillNumber.Text),
                CustomerID = selectedCustomer.CustomerID,
                PaymentDate = dtpPaymentDate.Value
            };
            // invoiceHeader.
            DbContextTransaction transaction = db.Database.BeginTransaction();

            try
            {
                db.InvoiceHeaders.Add(invoiceHeader);
                db.SaveChanges();
                ProductInputClear();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                MessageBox.Show("Beklenmeyen bir hata oluştu.");
            }
        }

        private void InvoiceInputsClear()
        {
            tbWaybillNumber.Text = "";
            DgvNewInvoiceClear();

            InvoiceDetails invoice = db.InvoiceDetails.ToList().LastOrDefault();
            invoiceID = invoice == null ? 1 : invoice.InvoiceID;
            lblInvoiceID.Text = invoiceID.ToString();

            ProductInputClear();
        }

        private void DgvNewInvoiceClear()
        {
            invoiceDetails = new HashSet<InvoiceDetails>();
            dgvNewInvoice.DataSource = invoiceDetails;
        }

        private bool InvoiceInputsControl()
        {
            if (selectedCustomer == null)
                return false;

            if (invoiceDetails.Count < 1)
                return false;

            if (string.IsNullOrWhiteSpace(tbWaybillNumber.Text))
                return false;

            if (dtpPaymentDate.Value == null)
                return false;

            try
            {
                Convert.ToInt32(tbWaybillNumber.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnListClear_Click(object sender, EventArgs e)
        {
            DgvNewInvoiceClear();
        }
    }
}
