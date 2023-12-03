using BUS.IService;
using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class OrderBusiness
    {
        private readonly IOrderRepos _orderRepository;

        public OrderBusiness(IOrderRepos orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void ProcessOrder(OrderHeader order, string voucherID)
        {
            // Thực hiện các bước xử lý đặt hàng

            // Kiểm tra và lấy thông tin voucher từ cơ sở dữ liệu
            Voucher voucher = _orderRepository.GetVoucherById(voucherID);

            // Tính tổng tiền và áp dụng voucher
            double totalAmount = order.CalculateTotalAmount();
            order.ApplyVoucher(voucher);

            // Lưu đơn đặt hàng vào cơ sở dữ liệu
            _orderRepository.SaveOrder(order);
        }
    }

}
