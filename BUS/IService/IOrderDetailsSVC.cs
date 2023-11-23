﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IOrderDetailsSVC
    {
        bool Add(OrderDetails obj);
        bool Update(OrderDetails obj);
        bool Delete(OrderDetails obj);
        List<OrderDetails> GetAll();
    }
}
