using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialSite.Entities.Entity.Concrete
{
   public class Shipper:BaseEntity
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
