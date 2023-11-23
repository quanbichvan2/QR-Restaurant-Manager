using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface ITableSVC
    {
        bool Add(Table obj);
        bool Update(Table obj);
        bool Delete(Table obj);
        List<Table> GetAll();
    }
}
