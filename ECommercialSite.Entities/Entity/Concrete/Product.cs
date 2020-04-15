using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialSite.Entities.Entity.Concrete
{
   public class Product:BaseEntity
    {
        [Required]
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public int QuantityPerUnit{ get; set; }
        public decimal UnitInStock { get; set; }
        public short UnitPrice { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReOrderLevel { get; set; }
        public int DisContinued { get; set; }
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
