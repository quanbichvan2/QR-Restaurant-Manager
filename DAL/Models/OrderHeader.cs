using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OrderHeader // Bill
    {
        [Key, MaxLength(10)] 
        public string OrderHeaderID { get; set; }

        [Required, MaxLength(5)]
        public string TableID { get; set; }
        [ForeignKey("TableID")]
        public Table TableEnity { get; set; }

        [Required]
        public double OrderTotal { get; set; }
        //nullable
        public double? Discount { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required, MaxLength(100)]
        public String OrderStatus { get; set; }
        [Required]
        public double VAT { get; set; }
        //nullable
        public string? Note { get; set; }
        public ICollection<Voucher> Vouchers { get; set; }
        public ICollection<OrderDetails> orderDetails { get; set; }
        // Constructor mặc định
        public OrderHeader()
        {
        }

        // Constructor có tham số để khởi tạo một đối tượng OrderHeader với các giá trị ban đầu
        public OrderHeader(string orderHeaderID, string tableID, double orderTotal, double? discount, DateTime orderDate, string orderStatus, double vat, string note)
        {
            OrderHeaderID = orderHeaderID;
            TableID = tableID;
            OrderTotal = orderTotal;
            Discount = discount;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
            VAT = vat;
            Note = note;
        }
    }

}
