using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IVoucherSVC
    {
        bool Add(Voucher obj);
        bool Update(Voucher obj);
        bool Delete(Voucher obj);
        List<Voucher> GetAll();
    }
}
