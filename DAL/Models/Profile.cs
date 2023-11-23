using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Profile
    {
        [Key, MaxLength(5)]
        public string ProfileID { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required, MaxLength(300)]
        public string Address { get; set; }
        [Required, MaxLength(10)]
        public string Phone { get; set; }
        [Required, MaxLength(12)]
        public string IdentifyCard { get; set; }
        [Required, MaxLength(10)]
        public string StaffShifts { get; set; }
        [Required, MaxLength(50)]
        public string Position { get; set; }
        [Required]
        public double Salary { get; set; }

        // Navigation property for the one-to-one relationship
        public Account Account { get; set; }
        public Profile()
        {

        }
        // Constructor có tham số để khởi tạo một đối tượng Profile với các giá trị ban đầu
        public Profile(string profileID, string fullName, string address, string phone, string identifyCard, string staffShifts, string position, double salary)
        {
            ProfileID = profileID;
            FullName = fullName;
            Address = address;
            Phone = phone;
            IdentifyCard = identifyCard;
            StaffShifts = staffShifts;
            Position = position;
            Salary = salary;
        }
    }
}
