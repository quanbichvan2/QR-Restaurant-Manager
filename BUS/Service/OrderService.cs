using BUS.IService;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class OrderService : IOrderService
    {
        public void ProcessOrder(OrderHeader order, Voucher voucher)
        {
            // Thực hiện các bước xử lý đặt hàng

            // Tính tổng tiền và áp dụng voucher
            double totalAmount = order.CalculateTotalAmount();
            order.ApplyVoucher(voucher);
        }
    }
}
