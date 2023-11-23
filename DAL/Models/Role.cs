using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Role
    {
        [Key]
        [MaxLength(5)]
        public string RoleID { get; set; }

        [Required, MaxLength(50)]
        public string RoleName { get; set; }
        public ICollection<Account> Accounts { get; set; }

        // Constructor mặc định
        public Role()
        {

        }

        // Constructor có tham số để khởi tạo một đối tượng Role với các giá trị ban đầu
        public Role(string roleID, string roleName)
        {
            RoleID = roleID;
            RoleName = roleName;
        }
    }
}
