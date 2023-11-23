using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IProductRepos
    {
        bool Add(Products products);
        bool Update(Products products);
        bool Delete(Products products);
        List<Products> GetAll();
    }
}
