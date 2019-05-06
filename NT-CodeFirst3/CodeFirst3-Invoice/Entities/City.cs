using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst3_Invoice.Entities
{
    public class City
    {
        public City()
        {
            this.counties = new HashSet<County>();
        }
        public int CityID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<County> counties { get; set; }
        //County--> BİR ŞEHRİN BİRDEN FAZLA İLÇESİ OLABİLİR.İLÇELERİ LİSTE HALİNDE TUTMAMIZ GEREKİR.
    }
}
