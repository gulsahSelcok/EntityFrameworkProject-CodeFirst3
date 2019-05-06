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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        InvoiceContext db = new InvoiceContext();

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            CountyFill();
            CityFill();
           // CustomerFill();
        }

        private void CityFill()
        {
            var cities = db.Cities.Select(x => new
            {
                x.CityID,
                x.Description
            }).ToList();
            cbCustomerCity.DisplayMember = "Description";
            cbCustomerCity.ValueMember = "CityID";
            cbCustomerCity.DataSource = cities;
        }
        private void CountyFill()
        {
            var counties = db.Counties.Select(x => new
            {
                x.CityID,
                x.Description
            }).ToList();
            cbCustomerCountry.DisplayMember = "Description";
            cbCustomerCountry.ValueMember = "CityID";
            cbCustomerCountry.DataSource = counties;
        }
        private void CustomerFill()
        {
            dataGridViewCustomer.DataSource = db.Customers.Select(x => new
            {
                x.CustomerID,
                x.CustomerName,
                City=x.county.city.Description,
                County=x.county.Description,
                x.Address
            }).ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerName = tbCustomerName.Text;
            customer.Address = tbCustomerAdress.Text;
            customer.CountyID = Convert.ToInt32(cbCustomerCountry.SelectedValue);
            db.Customers.Add(customer);
            db.SaveChanges();
            CustomerFill();
        }

        private void cbCustomerCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var counties = db.Counties.Where(x=>x.CityID==(int)(cbCustomerCity.SelectedValue)).Select(x => new
            {
                x.CountyID,
                x.Description
            }).ToList();
            cbCustomerCountry.DisplayMember = "Description";
            cbCustomerCountry.ValueMember = "CountyID";
            cbCustomerCountry.DataSource = counties;
        }
    }
}
