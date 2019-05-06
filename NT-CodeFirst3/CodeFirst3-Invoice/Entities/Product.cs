using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst3_Invoice.Entities
{
    public class Product
    {
        public Product()
        {
            this.invoiceDetails = new HashSet<InvoiceDetails>();
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int UnitID { get; set; }
        public decimal UnitPrice { get; set; }

        public Unit unit;
        public int InvoiceID { get; set; }

        public virtual ICollection<InvoiceDetails> invoiceDetails { get; set; }
       

    }
}
