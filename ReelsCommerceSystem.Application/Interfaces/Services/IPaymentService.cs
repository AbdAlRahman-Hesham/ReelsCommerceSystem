using ReelsCommerceSystem.Application.DTOs.Response.Payment;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

    public interface IPaymentService
    {
         Task<ApiResponse<PaymentResDto>> ProcessPaymentAsync(
            int orderId,
           PaymentMethod method,
           string userPhone = null,
           string userMpin = null,
           string userOtp = null);

         Task<ApiResponse<bool>> SetPayOnDeliveryAsync(int orderId);
    }
