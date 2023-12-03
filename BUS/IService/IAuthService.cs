using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IAuthService
    {
        bool Login(string username, string password);
        void Logout();
        bool IsLoggedIn();
        //bool ChangePasswordWithCode(string username, string newPassword, string code);

    }
}
