using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IOrderHeaderSVC
    {
        bool Add(OrderHeader obj);
        bool Update(OrderHeader obj);
        bool Delete(OrderHeader obj);
        List<OrderHeader> GetAll();
    }
}
