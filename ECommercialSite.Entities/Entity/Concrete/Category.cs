using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialSite.Entities.Entity.Concrete
{
    public class Category:BaseEntity
    {
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
