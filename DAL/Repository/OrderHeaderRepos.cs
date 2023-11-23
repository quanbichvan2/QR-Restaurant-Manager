using DAL.Context;
using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class OrderHeaderRepos : IOrderHeaderRepos
    {
        private QRDbContext dbContext;
        public OrderHeaderRepos(QRDbContext dbContextAccount)
        {
            dbContext = dbContextAccount;
        }
        public bool Add(OrderHeader OrderHeader)
        {
            dbContext.orderHeader.Add(OrderHeader);
            dbContext.SaveChanges();
            return true;
        }

        public bool Delete(OrderHeader OrderHeader)
        {
            dbContext.orderHeader.Remove(OrderHeader);
            dbContext.SaveChanges();
            return true;
        }

        public List<OrderHeader> GetAll()
        {
            return dbContext.orderHeader.ToList();
        }

        public bool Update(OrderHeader OrderHeader)
        {
            dbContext.orderHeader.Update(OrderHeader);
            dbContext.SaveChanges();
            return true;
        }
    }
}
