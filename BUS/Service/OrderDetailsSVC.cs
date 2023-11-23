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
    public class OrderDetailsSVC : IOrderDetailsSVC
    {
        IOrderDetailsRepos _orderDetailsSVC;
        public OrderDetailsSVC(IOrderDetailsRepos orderDetailsRepos) 
        {
            _orderDetailsSVC = orderDetailsRepos;
        }
        public bool Add(OrderDetails obj)
        {
            _orderDetailsSVC.Add(obj);
            return true;
        }

        public bool Delete(OrderDetails obj)
        {
            _orderDetailsSVC.Delete(obj);
            return true;
        }

        public List<OrderDetails> GetAll()
        {
            return _orderDetailsSVC.GetAll();
        }

        public bool Update(OrderDetails obj)
        {
            _orderDetailsSVC.Update(obj);
            return true;
        }
    }
}
