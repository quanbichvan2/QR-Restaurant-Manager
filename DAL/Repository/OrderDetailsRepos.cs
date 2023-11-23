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
    public class OrderDetailsRepos : IOrderDetailsRepos
    {
        private QRDbContext dbContext;
        public OrderDetailsRepos(QRDbContext dbContextAccount)
        {
            dbContext = dbContextAccount;
        }
        public bool Add(OrderDetails orderDetails)
        {
            dbContext.orderDetails.Add(orderDetails);
            dbContext.SaveChanges();
            return true;
        }

        public bool Delete(OrderDetails orderDetails)
        {
            dbContext.orderDetails.Remove(orderDetails);
            dbContext.SaveChanges();
            return true;
        }

        public List<OrderDetails> GetAll()
        {
            return dbContext.orderDetails.ToList();
        }

        public bool Update(OrderDetails orderDetails)
        {
            dbContext.orderDetails.Update(orderDetails);
            dbContext.SaveChanges();
            return true;
        }
    }
}
