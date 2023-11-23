using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class VoucherType
    {
        [Key, MaxLength(10)] public string VoucherTypeID { get; set; }
        [Required, MaxLength(300)] public string VoucherName { get; set; }
        [Required] public DateTime StartDate { get; set; }
        [Required] public DateTime EndDate { get; set; }
        [Required] public string Description { get; set; }
        public ICollection<Voucher> Vouchers { get; set; }
        // Constructor mặc định
        public VoucherType()
        {
        }

        // Constructor có tham số để khởi tạo một đối tượng VoucherType với các giá trị ban đầu
        public VoucherType(string voucherTypeID, string voucherName, DateTime startDate, DateTime endDate, string description)
        {
            VoucherTypeID = voucherTypeID;
            VoucherName = voucherName;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }
    }
}
