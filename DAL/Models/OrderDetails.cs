using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OrderDetails
    {
        [Key, MaxLength(10)]
        public string OrderDetailsID { get; set; }
        [Required, MaxLength(10)]
        public string ProductID { get; set; }
        [ForeignKey("ProductID")] // Define foreign key relationship
        public Products Product { get; set; }

        [Required, MaxLength(10)]
        public string OrderHeaderID { get; set; }
        [ForeignKey("OrderHeaderID")] // Define foreign key relationship
        public OrderHeader OrderHeaderEnity { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
