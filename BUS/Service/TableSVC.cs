// BUS.Service.TableSVC.cs
using BUS.IService;
using DAL.IRepository;
using DAL.Models;
using System.Collections.Generic;

namespace BUS.Service
{
    public class TableSVC : ITableSVC
    {
        ITableRepos _table;

        public TableSVC(ITableRepos tableRepos)
        {
            _table = tableRepos;
        }

        public bool Add(Table obj)
        {
            _table.Add(obj);
            return true;
        }

        public bool Delete(Table obj)
        {
            _table.Delete(obj);
            return true;
        }

        public List<Table> GetAll()
        {
            return _table.GetAll();
        }

        public bool Update(Table obj)
        {
            _table.Update(obj);
            return true;
        }
    }
}
