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
    public partial class FormInvoiceDetail : Form
    {

        InvoiceContext db = new InvoiceContext();
        private List<InvoiceDetails> _invoiceDetails;
        public FormInvoiceDetail(ICollection<InvoiceDetails> ınvoiceDetails)
        {
            InitializeComponent();
            _invoiceDetails = ınvoiceDetails.ToList();
            dgvInvoiceDetail.DataSource = _invoiceDetails;
        }

    }
}
