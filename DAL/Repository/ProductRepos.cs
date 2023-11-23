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
    public class ProductRepos : IProductRepos
    {
        private QRDbContext dbContext;
        public ProductRepos(QRDbContext dbContextAccount)
        {
            dbContext = dbContextAccount;
        }
        public bool Add(Products products)
        {
            dbContext.products.Add(products);
            dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Products products)
        {
            dbContext.products.Remove(products);
            dbContext.SaveChanges();
            return true;
        }

        public List<Products> GetAll()
        {
            return dbContext.products.ToList();
        }

        public bool Update(Products products)
        {
            dbContext.products.Update(products);
            dbContext.SaveChanges();
            return true;
        }
    }
}
