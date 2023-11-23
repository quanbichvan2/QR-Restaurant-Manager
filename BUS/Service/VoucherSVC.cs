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
    public class VoucherSVC : IVoucherSVC
    {
        IVoucherRepos _voucher;

        public VoucherSVC(IVoucherRepos VoucherRepos)
        {
            _voucher = VoucherRepos;
        }

        public bool Add(Voucher obj)
        {
            _voucher.Add(obj);
            return true;
        }

        public bool Delete(Voucher obj)
        {
            _voucher.Delete(obj);
            return true;
        }

        public List<Voucher> GetAll()
        {
            return _voucher.GetAll();
        }

        public bool Update(Voucher obj)
        {
            _voucher.Update(obj);
            return true;
        }
    }
}
