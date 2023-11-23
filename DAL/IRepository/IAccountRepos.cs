using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IAccountRepos
    {
        bool Add(Account account);
        bool Update(Account account);
        bool Delete(Account account);
        List<Account> GetAll();
    }
}
