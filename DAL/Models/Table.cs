using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Table
    {
        [Key, MaxLength(5)]
        public string TableID { get; set; }
        [Required, MaxLength(50)]
        public string TableName { get; set; }
        public Table() { }
        public Table(string tableName)
        {
            TableName = tableName;
        }
        public ICollection<OrderHeader> OrderHeaders { get; set; }
    }
}
