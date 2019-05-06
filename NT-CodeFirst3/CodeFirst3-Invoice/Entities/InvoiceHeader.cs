using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst3_Invoice.Entities
{
    public class InvoiceHeader
    {
        public InvoiceHeader()
        {
            this.invoiceDetails = new HashSet<InvoiceDetails>();
            this.customers = new HashSet<Customer>();
        }

        [Key]
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int DeliveryNote { get; set; }
        public DateTime PaymentDate { get; set; }
        public int TotalAmount { get; set; }

        public virtual ICollection<InvoiceDetails> invoiceDetails { get; set; }
        public virtual ICollection<Customer> customers { get; set; }
    }
}
