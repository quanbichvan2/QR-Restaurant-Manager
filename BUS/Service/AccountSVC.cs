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
    public class AccountSVC : IAccountSVC
    {
        IAccountRepos _Acc;
        public AccountSVC(IAccountRepos accountRepos)
        {
            _Acc = accountRepos;
        }
        public bool Add(Account obj)
        {
            _Acc.Add(obj);
            return true;
        }

        public bool Delete(Account obj)
        {
            _Acc.Delete(obj);
            return true;
        }

        public List<Account> GetAll()
        {
            return _Acc.GetAll();
        }

        public bool Update(Account obj)
        {
            _Acc.Update(obj);
            return true;
        }
    }
}
