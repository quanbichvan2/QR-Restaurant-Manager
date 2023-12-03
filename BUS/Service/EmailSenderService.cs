using BUS.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class EmailSenderService : IEmailSenderService
    {
        private const string USERNAME = "yourmail@gmail.com";
        private const string PASSWORD = "xdqzdhcrbmtryj312";
        private static string _code = string.Empty;
        private static DateTime _timeCreate;

        public async Task<bool> SendEmail(string emailTo)
        {
            _code = CodeGenerator.Generate();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(USERNAME);
            mail.To.Add(emailTo);
            mail.Subject = "RESET PASSWORD CODE";
            mail.Body = $"<strong>{_code}</strong> is your code.";
            mail.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(USERNAME, PASSWORD);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                await smtpClient.SendMailAsync(mail);
                _timeCreate = DateTime.Now;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool CheckCode(string inputCode)
        {
            TimeSpan timeSpan = DateTime.Now.Subtract(_timeCreate);
            if (timeSpan.TotalMinutes > 2)
                return false;
            if (inputCode != _code)
                return false;
            return true;
        }
        public static class CodeGenerator
        {
            private static readonly Random random = new Random();

            public static string Generate()
            {
                // Logic để sinh mã code ngẫu nhiên 6 chữ số và trả về
                int randomNumber = random.Next(100000, 999999);
                return randomNumber.ToString();
            }
        }
    }
}
