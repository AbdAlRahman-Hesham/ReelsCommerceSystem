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
            #region Get The Order With Order ID
            var spec = new OrderByIdWithOrderProductSpes(orderId);
            var order = await _unitOfWork.Repository<Order>().GetWithSpecAsync(spec);

            if (order == null)
                return ApiResponse<PaymentResDto>.ErrorResponse(HttpStatusCode.NotFound,
                    "Order not found", "الأوردر غير موجود"); 
            #endregion

            #region Check if order payment status not pending or failed
            var paymentSpec = new IsPaymentAllowedSpec();
            if (!paymentSpec.IsSatisfiedBy(order))
                return ApiResponse<PaymentResDto>.ErrorResponse(HttpStatusCode.BadRequest,
                    "Payment not allowed", "الدفع غير مسموح لهذا الأوردر");
            #endregion

            #region Check if expectedTotal == TotalAmount
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
            #endregion

            #region Create paymentUrl and link 
            var paymentUrl = await _paymobService.CreatePaymentUrlAsync(order, method, userPhone);


            int paymobOrderId = await _paymobService.GetLastCreatedOrderIdAsync();

            if (string.IsNullOrEmpty(paymentUrl.Data))
                return ApiResponse<PaymentResDto>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Failed to generate Paymob payment URL. Please try again later.",
                    "تعذر إنشاء رابط الدفع عبر باي موب. يرجى المحاولة مرة أخرى."
                );
            #endregion

            #region Update order with payment details
            order.PaymobOrderId = paymobOrderId;
            order.PaymentMethod = method;
            _unitOfWork.Repository<Order>().Update(order);
            var res = await _unitOfWork.SaveChangesAsync();

            if (res <= 0)
                return ApiResponse<PaymentResDto>.ErrorResponse(HttpStatusCode.InternalServerError,
                    "Failed to update order with payment details", "فشل تحديث الأوردر بتفاصيل الدفع");

            var response = new PaymentResDto
            {
                OrderId = order.Id,
                Amount = order.TotalAmount,
                PaymentUrl = paymentUrl.Data,
                PaymobOrderId = paymobOrderId
            };
            #endregion


            return ApiResponse<PaymentResDto>.SuccessResponse(response, HttpStatusCode.OK);
        }
    }

}
