using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Domain.Enums.Finance;

namespace ReelsCommerceSystem.Application.Interfaces.Services.Finance;

public interface IFinancialAuditLogRepository
{
    Task AddAsync(FinancialAuditLog log);
    Task<(List<FinancialAuditLog> Items, int TotalCount)> GetPagedAsync(AuditLogFilterDto filter);
}

public interface IBrandSettlementRepository
{
    Task<IReadOnlyList<BrandSettlement>> GetByBrandIdAsync(int brandId, SettlementFilterDto? filter = null);
    Task<BrandSettlement?> GetByIdAsync(int id);
    Task<List<BrandSettlement>> GetByIdsAsync(List<int> ids);
    Task<List<BrandSettlement>> GetByOrderIdAsync(int orderId);
    Task<List<BrandSettlement>> GetPendingTransferAsync(int maxRetries = 3);
    Task<decimal> GetSumByBrandAndStatusAsync(int brandId, SettlementStatus status);
    Task<int> GetCountByBrandIdAsync(int brandId);
    Task AddAsync(BrandSettlement settlement);
    void Update(BrandSettlement settlement);
    void UpdateRange(List<BrandSettlement> settlements);
    Task<int> SaveChangesAsync();
}

public interface IShippingSettlementRepository
{
    Task<IReadOnlyList<ShippingSettlement>> GetByCompanyIdAsync(int companyId, SettlementFilterDto? filter = null);
    Task<ShippingSettlement?> GetByIdAsync(int id);
    Task<List<ShippingSettlement>> GetByIdsAsync(List<int> ids);
    Task<List<ShippingSettlement>> GetByOrderIdAsync(int orderId);
    Task<decimal> GetSumByCompanyAndStatusAsync(int companyId, ShippingSettlementStatus status);
    Task AddAsync(ShippingSettlement settlement);
    void Update(ShippingSettlement settlement);
    void UpdateRange(List<ShippingSettlement> settlements);
    Task<int> SaveChangesAsync();
}

public interface IWithdrawalRequestRepository
{
    Task<List<WithdrawalRequest>> GetByBrandIdAsync(int brandId);
    Task<WithdrawalRequest?> GetByIdAsync(int id);
    Task<int> GetCountByBrandAndStatusAsync(int brandId, WithdrawalRequestStatus status);
    Task AddAsync(WithdrawalRequest request);
    void Update(WithdrawalRequest request);
    Task<int> SaveChangesAsync();
}
