using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst3_Invoice.Entities
{
    public class InvoiceDetails
    {
        [Key][Column(Order=0)]
        public int InvoiceID { get; set; }
        [Key][Column(Order = 1)]
        public int ProductID { get; set; }/// <summary>
        ///  İki primary key olmalı yapıya composit key denir.
        /// </summary>
        public int Qantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int VATAmount { get; set; }
        public int AmountWithVAT { get; set; }
        public string Description { get; set; }

        public virtual Product products { get; set; }
        public virtual InvoiceHeader invoiceHeader { get; set; }
}
}
