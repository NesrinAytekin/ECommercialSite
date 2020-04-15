using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialSite.Entities.Entity.Concrete
{
    public class Customer:BaseEntity
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }        
        public string Region { get; set; }        
        public string PostalCode { get; set; }        
        public string Country { get; set; }    
        public string Phone { get; set; }        
        public string Fax { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
