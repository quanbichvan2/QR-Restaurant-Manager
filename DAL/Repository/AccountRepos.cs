using DAL.Context;
using DAL.IRepository;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class AccountRepos : IAccountRepos
    {
        private QRDbContext dbContext;
        public AccountRepos(QRDbContext dbContextAccount)
        {
            dbContext = dbContextAccount;
        }
        public bool Add(Account account)
        {
            dbContext.Accounts.Add(account);
            dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Account account)
        {
            dbContext.Accounts.Remove(account);
            dbContext.SaveChanges();
            return true;
        }

        public List<Account> GetAll()
        {
            return dbContext.Accounts.ToList();
        }

        public bool Update(Account account)
        {
            dbContext.Accounts.Update(account);
            dbContext.SaveChanges();
            return true;
        }
    }
}
