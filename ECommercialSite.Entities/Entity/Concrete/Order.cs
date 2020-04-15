using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialSite.Entities.Entity.Concrete
{
    public class Order:BaseEntity
    {   
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        [Required]
        public string ShipVia { get; set; }
        [Required]
        public string Freight { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string ShipAdress { get; set; }
        [Required]
        public string ShipCity { get; set; }
        [Required]
        public string ShipRegion { get; set; }
        [Required]
        public string ShipPostalCode { get; set; }
        [Required]
        public string ShipCountry { get; set; }
        
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Shipper Shipper { get; set; }


    }
}
