using CodeFirst3_Invoice.Context;
using CodeFirst3_Invoice.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst3_Invoice
{
    public partial class FormInvoiceView : Form
    {
        InvoiceContext db = new InvoiceContext();
        private Customer selectedCustomer;
        private List<InvoiceHeader> invoiceHeaders = new List<InvoiceHeader>();
        public FormInvoiceView()
        {
            InitializeComponent();
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedIndex == -1)
                return;

            selectedCustomer = (Customer) cbCustomer.SelectedItem;
        }

        private void cbCustomerCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerCity.SelectedIndex == -1)
                return;

            int cityId = Convert.ToInt32(cbCustomerCity.SelectedValue);
            cbCustomerCounty.DisplayMember = "Description";
            cbCustomerCounty.ValueMember = "CountyID";
            cbCustomerCounty.DataSource = db.Counties.Where(x => x.CityID == cityId).ToList();
        }

        private void cbCustomerCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerCounty.SelectedIndex == -1)
                return;

            int countyID = Convert.ToInt32(cbCustomerCounty.SelectedValue);
            cbCustomer.DisplayMember = "CustomerName";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DataSource = db.Customers.Where(x => x.CountyID == countyID).ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbInvoiceID.Text))
            {
                if (selectedCustomer == null)
                    invoiceHeaders = db.InvoiceHeaders.ToList();
                else
                    invoiceHeaders = db.InvoiceHeaders.Where(x => x.CustomerID == selectedCustomer.CustomerID).ToList();
            }
            else
            {
                if (!InvoiceControl())
                    return;

                int invoiceID = Convert.ToInt32(tbInvoiceID.Text);

                if (selectedCustomer == null)
                    invoiceHeaders = db.InvoiceHeaders.Where(x => x.InvoiceID == invoiceID).ToList();
                else
                    invoiceHeaders = db.InvoiceHeaders.Where(x => x.InvoiceID == invoiceID && x.CustomerID == selectedCustomer.CustomerID).ToList();
            }

            dgvInvoice.DataSource = invoiceHeaders;
        }

        private bool InvoiceControl()
        {
            if (string.IsNullOrWhiteSpace(tbInvoiceID.Text))
                return false;

            try
            {
                Convert.ToInt32(tbInvoiceID.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            selectedCustomer = null;
            cbCustomer.SelectedItem = null;
            tbInvoiceID.Text = "";
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvInvoice.CurrentRow == null)
                return;

            InvoiceHeader invoiceHeader = (InvoiceHeader)dgvInvoice.CurrentRow.DataBoundItem;
            FormInvoiceDetail formInvoiceDetail = new FormInvoiceDetail(invoiceHeader.invoiceDetails);
            formInvoiceDetail.ShowDialog();
        }
    }
}
