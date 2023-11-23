using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Voucher
    {
        [Key, MaxLength(10)] public string VoucherID { get; set; }
        [Required, MaxLength(10)]
        public string VoucherTypeID { get; set; }
        [ForeignKey ("VoucherTypeID")]
        public VoucherType VoucherTypeEnity { get; set; }

        [Required, MaxLength(10)]
        public string OrderHeaderID { get; set; }
        [ForeignKey("OrderHeaderID")]
        public OrderHeader OrderHeaderEnity { get; set; }

        [Required]
        public bool IsValid { get; set; }
    }
}
