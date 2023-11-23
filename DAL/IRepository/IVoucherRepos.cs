using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IVoucherRepos
    {
        bool Add(Voucher Voucher);
        bool Update(Voucher Voucher);
        bool Delete(Voucher Voucher);
        List<Voucher> GetAll();
    }
}
