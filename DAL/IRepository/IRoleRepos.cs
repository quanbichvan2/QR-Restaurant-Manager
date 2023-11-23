using DAL.Models;
using System.Collections.Generic;

namespace DAL.IRepository
{
    public interface IRoleRepos
    {
        bool Add(Role role);
        bool Update(Role role);
        bool Delete(Role role);
        List<Role> GetAll();
    }
}
