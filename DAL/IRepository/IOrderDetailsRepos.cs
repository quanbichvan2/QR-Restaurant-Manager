using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IOrderDetailsRepos
    {
        bool Add(OrderDetails orderDetails);
        bool Update(OrderDetails orderDetails);
        bool Delete(OrderDetails orderDetails);
        List<OrderDetails> GetAll();
    }
}
