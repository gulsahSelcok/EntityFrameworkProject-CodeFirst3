using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst3_Invoice.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int CountyID { get; set; }
        public string Address { get; set; }

        public County county { get; set; }
        public InvoiceHeader invoiceHeader;
    }
}
