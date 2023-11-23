using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ITableRepos
    {
        bool Add(Table table);
        bool Update(Table table);
        bool Delete(Table table);
        List<Table> GetAll();
    }
}
