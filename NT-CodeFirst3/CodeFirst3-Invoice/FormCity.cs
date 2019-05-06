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
    public partial class FormCity : Form
    {
        public FormCity()
        {
            InitializeComponent();
        }
        InvoiceContext db = new InvoiceContext();

        private void FormCity_Load(object sender, EventArgs e)
        {
            //CityFill();
        }
        private void CityFill()
        {
            dataGridViewCity.DataSource = db.Cities.Select(x => new
            {
                x.CityID,
                x.Description
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.Description = tbCityName.Text;
            db.Cities.Add(city);
            db.SaveChanges();
            CityFill();
        }

    }
}
