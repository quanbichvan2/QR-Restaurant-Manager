using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IAccountSVC
    {
        bool Add(Account obj);
        bool Update(Account obj);
        bool Delete(Account obj);
        List<Account> GetAll();
    }
}
