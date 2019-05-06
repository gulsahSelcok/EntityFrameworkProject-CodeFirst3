using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst3_Invoice.Entities
{
    public class County
    {
        public County()
        {
            this.customers = new HashSet<Customer>();
        }
        public int CountyID { get; set; }
        public string Description { get; set; }
        public int CityID { get; set; }

        public virtual City city { get; set; }

        public virtual ICollection<Customer> customers { get; set; }
    }
}
