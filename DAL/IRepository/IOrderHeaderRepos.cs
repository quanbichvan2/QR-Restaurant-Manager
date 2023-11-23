using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IOrderHeaderRepos
    {
        bool Add(OrderHeader OrderHeader);
        bool Update(OrderHeader OrderHeader);
        bool Delete(OrderHeader OrderHeader);
        List<OrderHeader> GetAll();
    }
}
