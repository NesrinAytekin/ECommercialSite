using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialSite.Entities.Entity.Concrete
{
    public class Employee:BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string TitleOfCourtesy { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime HireDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string HomePhone { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public string ReportsTo { get; set; }
        public virtual ICollection<Order>Orders{ get; set; }
    }
}
