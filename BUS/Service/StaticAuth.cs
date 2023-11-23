using DAL.Models;

namespace BUS_QLBanHang.Service
{
    public class StaticAuth
    {
        public static Account auth = null;
        // static cho phần đăng nhập biết được ai đang login và quyền của người đó.
    }
}