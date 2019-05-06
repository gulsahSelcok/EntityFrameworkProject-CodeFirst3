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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCity frm = new FormCity();
            frm.Show();
        }

        private void customeDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer frm = new FormCustomer();
            frm.Show();
        }

        private void unitDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnit frm = new FormUnit();
            frm.Show();
        }

        private void productDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct frm = new FormProduct();
            frm.Show();
        }

        private void countyDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCounty frm = new FormCounty();
            frm.Show();
        }
    }
}
