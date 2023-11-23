using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IVoucherTypeSVC
    {
        bool Add(VoucherType obj);
        bool Update(VoucherType obj);
        bool Delete(VoucherType obj);
        List<VoucherType> GetAll();
    }
}
