using ReelsCommerceSystem.Application.DTOs.Response.Payment;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OrderSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.PaymentSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymobService _paymobService;

        public PaymentService(IUnitOfWork unitOfWork, IPaymobService paymobService)
        {
            _unitOfWork = unitOfWork;
            _paymobService = paymobService;
        }

        public async Task<ApiResponse<PaymentResDto>> ProcessPaymentAsync(
             int orderId,
             PaymentMethod method,
            string userPhone = null,
            string userMpin = null,
            string userOtp = null)
        {
           
            var spec = new OrderByIdWithOrderProductSpes(orderId);
            var order = await _unitOfWork.Repository<Order>().GetWithSpecAsync(spec);

            if (order == null)
                return ApiResponse<PaymentResDto>.ErrorResponse(HttpStatusCode.NotFound,
                    "Order not found", "الأوردر غير موجود");

            foreach (var p in order.OrderProducts)
            {
                Console.WriteLine($"Product: {p.ProductName}, FinalPrice: {p.FinalPrice}, Quantity: {p.Quantity}");
            }

            var paymentSpec = new IsPaymentAllowedSpec();
            if (!paymentSpec.IsSatisfiedBy(order))
                return ApiResponse<PaymentResDto>.ErrorResponse(HttpStatusCode.BadRequest,
                    "Payment not allowed", "الدفع غير مسموح لهذا الأوردر");

            
            decimal productsTotal = order.OrderProducts.Sum(p => p.FinalPrice * p.Quantity);
            decimal shipping = order.DeliveryMethod switch
            {
                DeliveryMethod.Standard => 60,
                DeliveryMethod.Express => 120,
                DeliveryMethod.HomeDelivery => 80,
                _ => 60
            };

            decimal expectedTotal = productsTotal + shipping;

            if (order.TotalAmount != expectedTotal)
                return ApiResponse<PaymentResDto>.ErrorResponse(HttpStatusCode.BadRequest,
                    "Order amount mismatch", "مبلغ الأوردر غير مطابق");

            
            var paymentUrl = await _paymobService.CreatePaymentUrlAsync(order, method);

           
            string paymobOrderId = await _paymobService.GetLastCreatedOrderIdAsync();

            
            var response = new PaymentResDto
            {
                OrderId = order.Id,
                Amount = order.TotalAmount,
                PaymentUrl = paymentUrl.Data,
                PaymobOrderId = paymobOrderId
            };

            return ApiResponse<PaymentResDto>.SuccessResponse(response, HttpStatusCode.OK);
        }
    }

}
