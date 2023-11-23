using BUS.IService;
using DAL.IRepository;
using DAL.Models;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ProductSVC : IProductSVC
    {
        IProductRepos _product;
        public ProductSVC(IProductRepos ProductRepos)
        {
            _product = ProductRepos;
        }
        public bool Add(Products obj)
        {
            _product.Add(obj);
            return true;
        }

        public bool Delete(Products obj)
        {
            _product.Delete(obj);
            return true;
        }

        public List<Products> GetAll()
        {
            return _product.GetAll();
        }

        public bool Update(Products obj)
        {
            _product.Update(obj);
            return true;
        }
    }
}
