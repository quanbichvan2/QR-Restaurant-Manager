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
    public class VoucherTypeSVC : IVoucherTypeSVC
    {
        IVoucherTypeRepos _VoucherType;

        public VoucherTypeSVC(IVoucherTypeRepos VoucherTypeRepos)
        {
            _VoucherType = VoucherTypeRepos;
        }

        public bool Add(VoucherType obj)
        {
            _VoucherType.Add(obj);
            return true;
        }

        public bool Delete(VoucherType obj)
        {
            _VoucherType.Delete(obj);
            return true;
        }

        public List<VoucherType> GetAll()
        {
            return _VoucherType.GetAll();
        }

        public bool Update(VoucherType obj)
        {
            _VoucherType.Update(obj);
            return true;
        }
    }
}
