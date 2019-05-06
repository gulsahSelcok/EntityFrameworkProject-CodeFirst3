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
using CodeFirst3_Invoice.Context;

namespace CodeFirst3_Invoice
{
    public partial class FormCounty : Form
    {
        public FormCounty()
        {
            InitializeComponent();
        }
        InvoiceContext db = new InvoiceContext();
        private void FormCounty_Load(object sender, EventArgs e)
        {
            CountyFill();
            CityFill();
        }
        private void CityFill()
        {
            var cities = db.Cities.Select(x => new
            {
                x.CityID,
                x.Description
            }).ToList();
            cbCityName.DisplayMember = "Description";
            cbCityName.ValueMember = "CityID";
            cbCityName.DataSource = cities;
        }

        private void CountyFill()
        {
            dataGridViewCounty.DataSource = db.Counties.Select(x => new
            {
                x.CityID,
                CityName = x.city.Description,
                x.CountyID,
                CountyName=x.Description
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            County county = new County();
            county.Description = tbCountyName.Text;
            county.CityID= Convert.ToInt32(cbCityName.SelectedValue);
            db.Counties.Add(county);
            db.SaveChanges();
            CountyFill();
        }

    }
}
