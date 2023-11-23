using DAL.Models;
using System.Collections.Generic;

namespace BUS.IService
{
    public interface IProfileSVC
    {
        bool Add(Profile obj);
        bool Update(Profile obj);
        bool Delete(Profile obj);
        List<Profile> GetAll();
    }
}
