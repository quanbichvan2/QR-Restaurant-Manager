using BUS.IService;
using DAL.IRepository;
using DAL.Models;
using System.Collections.Generic;

namespace BUS.Service
{
    public class ProfileSVC : IProfileSVC
    {
        IProfileRepos _profile;

        public ProfileSVC(IProfileRepos profileRepos)
        {
            _profile = profileRepos;
        }

        public bool Add(Profile obj)
        {
            _profile.Add(obj);
            return true;
        }

        public bool Delete(Profile obj)
        {
            _profile.Delete(obj);
            return true;
        }

        public List<Profile> GetAll()
        {
            return _profile.GetAll();
        }

        public bool Update(Profile obj)
        {
            _profile.Update(obj);
            return true;
        }
    }
}
