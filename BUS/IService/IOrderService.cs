using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    // Interface cho service
    public interface IOrderService
    {
        void ProcessOrder(OrderHeader order, Voucher voucher);
    }
}
