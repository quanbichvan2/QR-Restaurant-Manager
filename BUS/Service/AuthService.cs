using BUS.IService;
using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class AuthService : IAuthService
    {
        private List<string> userRoles; // Khai báo biến userRoles ở cấp độ của lớp AuthService

        private bool loggedIn = false;
        private readonly IAccountRepos accountRepository;
        private readonly IProfileRepos profileRepository;
        public AuthService(IAccountRepos accountRepository, IProfileRepos profileRepository)
        {
            this.accountRepository = accountRepository;
            this.profileRepository = profileRepository;
            // Khởi tạo userRoles tại đây để phòng trường hợp nullable với UserRoles
            userRoles = new List<string>();
        }
        public bool Login(string username, string password)
        {

            // Thực hiện logic kiểm tra đăng nhập, có thể kiểm tra cơ sở dữ liệu, gọi API, ...
            // Nếu đăng nhập thành công, đặt giá trị loggedIn là true.
            Account user = accountRepository.ValidateLogin(username, password);
            // Trả về true nếu đăng nhập thành công, ngược lại là false.
            if (user != null)
            {
                // Đăng nhập thành công, đặt giá trị loggedIn là true.
                loggedIn = true;
                return true;
            }

            // Đăng nhập thất bại
            return false;
        }

        public void Logout()
        {
            // Thực hiện logic đăng xuất, đặt giá trị loggedIn là false.
            loggedIn = false;
        }

        public bool IsLoggedIn()
        {
            return loggedIn;
        }
        //phân quyền tại đây
        /*
        public void PerformSomeAction()
        {
            // Lấy thông tin về người dùng hiện tại từ cơ sở dữ liệu
            var currentUser = accountRepository.GetCurrentUser(); // Hãy cài đặt phương thức này trong IAccountRepos

            if (currentUser != null && currentUser.RoleID == "Admin")
            {
                // Thực hiện hành động chỉ cho Admin
                Console.WriteLine("chọn các bảng nào đi, phần này FE tự xử nó đc xài bảng nào và ko đc xài nhé");
            }
            else
            {
                // Hiển thị thông báo "Không có quyền hạn"
                Console.WriteLine("Không có quyền hạn truy cập");
            }
        }
        public bool CreateAccountForAdmin(string username, string email)
        {
            // Kiểm tra xem người dùng hiện tại có quyền là Admin hay không
            var currentUser = accountRepository.GetCurrentUser();
            if (currentUser != null && currentUser.RoleID == "Admin")
            {
                // Tạo một đối tượng Profile mới với các trường bắt buộc
                var newProfile = new Profile
                {
                    // Các giá trị mặc định của Profile
                    // ...

                    // Không cần nhập Account tại đây vì sẽ tạo mới tài khoản ở bước sau
                };

                // Tạo một tài khoản mới với mật khẩu mặc định và role mặc định
                var newAccount = new Account
                {
                    UserName = username,
                    Password = "123", // Mật khẩu mặc định
                    Email = email,
                    RoleID = "Employee" // Role mặc định
                };

                // Kết nối Profile và Account
                newAccount.Profile = newProfile;

                // Thêm Profile và Account vào cơ sở dữ liệu
                profileRepository.Add(newProfile);
                accountRepository.Add(newAccount);

                // Tài khoản được tạo thành công
                return true;
            }
            // Người dùng hiện tại không phải là Admin, không có quyền tạo tài khoản
            return false;
        }
        public bool ChangePasswordWithCode(string username, string newPassword, string code)
        {
            // Tạo một thể hiện của EmailSenderService
            var emailSenderService = new EmailSenderService();

            // Kiểm tra mã code
            if (emailSenderService.CheckCode(code))
            {
                // Mã code hợp lệ, thực hiện thay đổi mật khẩu
                var user = accountRepository.GetUserByUsername(username);
                if (user != null)
                {
                    // Thực hiện thay đổi mật khẩu trong cơ sở dữ liệu
                    user.Password = newPassword;
                    accountRepository.Update(user);

                    // Đăng xuất người dùng (nếu cần)
                    Logout();

                    return true;
                }
                else
                {
                    // Người dùng không tồn tại
                    return false;
                }
            }
            else
            {
                // Mã code không hợp lệ
                return false;
            }
        }

        */
    }

}
