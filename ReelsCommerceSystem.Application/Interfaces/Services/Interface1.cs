using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IPaymobService
{
    Task<ApiResponse<string>> CreatePaymentUrlAsync(Order order, PaymentMethod method);
    Task<string?> GetLastCreatedOrderIdAsync();

}
