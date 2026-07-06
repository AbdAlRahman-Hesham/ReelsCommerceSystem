using ReelsCommerceSystem.Application.DTOs.Common;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Application.DTOs.Response.Finance;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services.Finance;

public interface IFinanceService
{
    Task<BrandWalletSummaryDto> GetBrandWalletSummaryAsync(int brandId);
    Task<PagedResult<BrandSettlementDto>> GetBrandSettlementsAsync(int brandId, SettlementFilterDto filter);
    Task<WithdrawalRequestDto> CreateWithdrawalRequestAsync(int brandId, CreateWithdrawalReqDto request);
    Task<List<WithdrawalRequestDto>> GetBrandWithdrawalHistoryAsync(int brandId);
    Task<BrandPolicyDto> GetBrandPolicyAsync();

    Task<ShippingWalletSummaryDto> GetShippingWalletSummaryAsync(int shippingCompanyId);
    Task<List<ShippingSettlementDto>> GetShippingSettlementsAsync(int shippingCompanyId, SettlementFilterDto filter);
    Task<ShippingPolicyDto> GetShippingPolicyAsync();

    Task<AdminDashboardDto> GetAdminDashboardAsync();
    Task<List<AdminBrandFinanceSummaryDto>> GetAdminBrandFinanceSummaryAsync();
    Task<AdminBrandFinanceDetailDto> GetAdminBrandFinanceDetailAsync(int brandId);
    Task<List<AdminShippingFinanceSummaryDto>> GetAdminShippingFinanceSummaryAsync();
    Task<AdminShippingFinanceDetailDto> GetAdminShippingFinanceDetailAsync(int companyId);
    Task PayBrandSettlementsAsync(string adminId, PayBrandSettlementsReqDto request, string? ipAddress = null);
    Task PayShippingSettlementsAsync(string adminId, PayShippingSettlementsReqDto request, string? ipAddress = null);
    Task<AdminPolicyDto> GetAdminPolicyAsync();

    Task CalculateAndCreateSettlementsAsync(int orderId);
    Task UpdateSettlementsOnDeliveryAsync(int orderId);
}
