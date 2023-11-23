using DAL.Context;
using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProfileRepos : IProfileRepos
    {
        private QRDbContext dbContext;
        public ProfileRepos(QRDbContext dbContextAccount)
        {
            dbContext = dbContextAccount;
        }
        public bool Add(Profile profile)
        {
            dbContext.profiles.Add(profile);
            dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Profile profile)
        {
            dbContext.profiles.Remove(profile);
            dbContext.SaveChanges();
            return true;
        }

        public List<Profile> GetAll()
        {
            return dbContext.profiles.ToList();
        }

        public bool Update(Profile profile)
        {
            dbContext.profiles.Update(profile);
            dbContext.SaveChanges();
            return true;
        }
    }
}
