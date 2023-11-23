using DAL.Models;
using System.Collections.Generic;

namespace BUS.IService
{
    public interface IRoleSVC
    {
        bool Add(Role obj);
        bool Update(Role obj);
        bool Delete(Role obj);
        List<Role> GetAll();
    }
}
