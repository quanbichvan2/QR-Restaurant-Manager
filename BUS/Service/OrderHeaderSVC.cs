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
    public class OrderHeaderSVC : IOrderHeaderSVC
    {
        IOrderHeaderRepos _OrderHeader;
        public OrderHeaderSVC(IOrderHeaderRepos ProductRepos)
        {
            _OrderHeader = ProductRepos;
        }
        public bool Add(OrderHeader obj)
        {
            _OrderHeader.Add(obj);
            return true;
        }

        public bool Delete(OrderHeader obj)
        {
            _OrderHeader.Delete(obj);
            return true;
        }

        public List<OrderHeader> GetAll()
        {
            return _OrderHeader.GetAll();
        }

        public bool Update(OrderHeader obj)
        {
            _OrderHeader.Update(obj);
            return true;
        }
    }
}
