namespace CodeFirst3_Invoice.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CodeFirst3_Invoice.Entities;

    public class InvoiceContext : DbContext
    {
        
        public InvoiceContext()
            : base("name=InvoiceContext")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceHeader> InvoiceHeaders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
    }

   
}