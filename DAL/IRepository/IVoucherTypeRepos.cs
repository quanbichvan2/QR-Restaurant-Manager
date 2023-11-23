using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IVoucherTypeRepos
    {
        bool Add(VoucherType VoucherType);
        bool Update(VoucherType VoucherType);
        bool Delete(VoucherType VoucherType);
        List<VoucherType> GetAll();
    }
}
