using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IProfileRepos
    {
        bool Add(Profile profile);
        bool Update(Profile profile);
        bool Delete(Profile profile);
        List<Profile> GetAll();
    }
}
