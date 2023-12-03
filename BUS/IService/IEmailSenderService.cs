using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IEmailSenderService
    {
        Task<bool> SendEmail(string emailTo);
        bool CheckCode(string inputCode);
    }
}
