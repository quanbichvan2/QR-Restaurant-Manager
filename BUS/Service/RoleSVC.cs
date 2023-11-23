using BUS.IService;
using DAL.IRepository;
using DAL.Models;
using DAL.Repository;
using System.Collections.Generic;

namespace BUS.Service
{
    public class RoleSVC : IRoleSVC
    {
        private readonly IRoleRepos _role;

        public RoleSVC(IRoleRepos roleRepos)
        {
            _role = roleRepos;
        }

        public bool Add(Role obj)
        {
            _role.Add(obj);
            return true;
        }

        public bool Delete(Role obj)
        {
            _role.Delete(obj);
            return true;
        }

        public List<Role> GetAll()
        {
            return _role.GetAll();
        }

        public bool Update(Role obj)
        {
            _role.Update(obj);
            return true;
        }
    }
}
