using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IPaymobService
{
    Task<ApiResponse<string>> CreatePaymentUrlAsync(Order order, PaymentMethod method, string walletPhone = null);
    Task<int> GetLastCreatedOrderIdAsync();

}
