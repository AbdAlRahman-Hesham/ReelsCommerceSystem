using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Payment;
using ReelsCommerceSystem.Application.DTOs.Response.Payment;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class PaymentController : AppBaseController
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("pay")]
        public async Task<IActionResult> PayWithCard([FromBody] CreatePaymentReqDto request)
        {
            try
            {
               
                var paymentResult = await _paymentService.ProcessPaymentAsync(request.OrderId, request.PaymentMethod);


                return Ok(paymentResult);
            }
            catch (Exception ex)
            {
                // لو حصل خطأ
                return BadRequest(ApiResponse<PaymentResDto>.ErrorResponse(
                    statusCode: HttpStatusCode.BadRequest,
                    en: ex.Message,
                    ar: "حدث خطأ أثناء معالجة الدفع"
                ));
            }
        }

        [HttpPost("api/payments/wallet")]
        public async Task<IActionResult> PayWithWallet([FromBody] WalletPaymentReq request)
        {
            // 1️⃣ استدعاء الخدمة مع بيانات Wallet
            var result = await _paymentService.ProcessPaymentAsync(
                orderId: request.OrderId,
                method: PaymentMethod.Wallet,
                userPhone: request.Phone,
                userMpin: request.Mpin,
                userOtp: request.Otp
            );

            return Ok(result);
        }
    }
}
