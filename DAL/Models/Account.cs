using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Account
    {
        [Key, MaxLength(5)] public string Id { get; set; }

        [Required]
        [MaxLength(5)]
        public string RoleID { get; set; }

        [ForeignKey("RoleID")]
        public Role RoleEnity { get; set; }
        // RoleEntity: Một đối tượng Role đại diện cho mối quan hệ với vai trò.

        [Required]
        [MaxLength(5)]
        public string ProfileID { get; set; }
        [ForeignKey("ProfileID")] 
        public Profile Profile { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        public Account(string userName, string password, string email)
        {
            UserName = userName;
            Password = password;
            Email = email;
        }
        public Account() { }
        
    }
}
