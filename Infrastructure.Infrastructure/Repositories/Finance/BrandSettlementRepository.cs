using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Domain.Enums.Finance;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Infrastructure.Repositories.Finance;

public class BrandSettlementRepository : IBrandSettlementRepository
{
    private readonly AppDbContext _context;

    public BrandSettlementRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<BrandSettlement>> GetByBrandIdAsync(int brandId, SettlementFilterDto? filter = null)
    {
        var query = _context.BrandSettlements
            .Include(x => x.Order)
            .Where(x => x.BrandId == brandId);

        if (filter != null)
        {
            if (filter.Status.HasValue)
                query = query.Where(x => x.Status == filter.Status.Value);
            if (filter.DateFrom.HasValue)
                query = query.Where(x => x.CreatedAt >= filter.DateFrom.Value);
            if (filter.DateTo.HasValue)
                query = query.Where(x => x.CreatedAt <= filter.DateTo.Value);

            query = query.OrderByDescending(x => x.CreatedAt);
        }

        return await query.ToListAsync();
    }

    public async Task<BrandSettlement?> GetByIdAsync(int id)
    {
        return await _context.BrandSettlements
            .Include(x => x.Brand)
            .Include(x => x.Order)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<BrandSettlement>> GetByIdsAsync(List<int> ids)
    {
        return await _context.BrandSettlements
            .Include(x => x.Brand)
            .Include(x => x.Order)
            .Where(x => ids.Contains(x.Id))
            .ToListAsync();
    }

    public async Task<List<BrandSettlement>> GetByOrderIdAsync(int orderId)
    {
        return await _context.BrandSettlements
            .Where(x => x.OrderId == orderId)
            .ToListAsync();
    }

    public async Task<List<BrandSettlement>> GetPendingTransferAsync(int maxRetries = 3)
    {
        return await _context.BrandSettlements
            .Include(x => x.Brand)
            .Where(x => (x.Status == SettlementStatus.TransferInitiated || x.Status == SettlementStatus.Processing)
                        && x.RetryCount < maxRetries)
            .ToListAsync();
    }

    public async Task<decimal> GetSumByBrandAndStatusAsync(int brandId, SettlementStatus status)
    {
        return await _context.BrandSettlements
            .Where(x => x.BrandId == brandId && x.Status == status)
            .SumAsync(x => x.NetAmount);
    }

    public async Task AddAsync(BrandSettlement settlement)
    {
        await _context.BrandSettlements.AddAsync(settlement);
    }

    public void Update(BrandSettlement settlement)
    {
        _context.BrandSettlements.Update(settlement);
    }

    public void UpdateRange(List<BrandSettlement> settlements)
    {
        _context.BrandSettlements.UpdateRange(settlements);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
