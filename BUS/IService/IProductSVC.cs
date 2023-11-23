using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IProductSVC
    {
        bool Add(Products obj);
        bool Update(Products obj);
        bool Delete(Products obj);
        List<Products> GetAll();
    }
}
