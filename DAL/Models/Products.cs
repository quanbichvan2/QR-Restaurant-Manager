using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Products
    {
        [Key, MaxLength(10)]
        public string ProductID { get; set; }
        [Required, MaxLength(200)]
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public bool IsInStock { get; set; }
        public ICollection<OrderDetails> orderDetails{ get; set; }
        public Products()
        {
        }

        // Constructor có tham số để khởi tạo một đối tượng Products với các giá trị ban đầu
        public Products(string productID, string productName, double price, string category, string image, bool isInStock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Category = category;
            Image = image;
            IsInStock = isInStock;
        }
    }
}
