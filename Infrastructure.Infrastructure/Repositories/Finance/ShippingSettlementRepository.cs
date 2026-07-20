using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Domain.Enums.Finance;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Infrastructure.Repositories.Finance;

public class ShippingSettlementRepository : IShippingSettlementRepository
{
    private readonly AppDbContext _context;

    public ShippingSettlementRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<ShippingSettlement>> GetByCompanyIdAsync(int companyId, SettlementFilterDto? filter = null)
    {
        var query = _context.ShippingSettlements
            .Include(x => x.Order)
            .Where(x => x.ShippingCompanyId == companyId);

        if (filter != null)
        {
            if (filter.Status.HasValue)
                query = query.Where(x => x.Status == (ShippingSettlementStatus)filter.Status.Value);
            if (filter.DateFrom.HasValue)
                query = query.Where(x => x.CreatedAt >= filter.DateFrom.Value);
            if (filter.DateTo.HasValue)
                query = query.Where(x => x.CreatedAt <= filter.DateTo.Value);

            query = query.OrderByDescending(x => x.CreatedAt);
        }

        return await query.ToListAsync();
    }

    public async Task<ShippingSettlement?> GetByIdAsync(int id)
    {
        return await _context.ShippingSettlements
            .Include(x => x.ShippingCompany)
            .Include(x => x.Order)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<ShippingSettlement>> GetByIdsAsync(List<int> ids)
    {
        return await _context.ShippingSettlements
            .Where(x => ids.Contains(x.Id))
            .ToListAsync();
    }

    public async Task<List<ShippingSettlement>> GetByOrderIdAsync(int orderId)
    {
        return await _context.ShippingSettlements
            .Where(x => x.OrderId == orderId)
            .ToListAsync();
    }

    public async Task<decimal> GetSumByCompanyAndStatusAsync(int companyId, ShippingSettlementStatus status)
    {
        return await _context.ShippingSettlements
            .Where(x => x.ShippingCompanyId == companyId && x.Status == status)
            .SumAsync(x => x.Amount);
    }

    public async Task AddAsync(ShippingSettlement settlement)
    {
        await _context.ShippingSettlements.AddAsync(settlement);
    }

    public void Update(ShippingSettlement settlement)
    {
        _context.ShippingSettlements.Update(settlement);
    }

    public void UpdateRange(List<ShippingSettlement> settlements)
    {
        _context.ShippingSettlements.UpdateRange(settlements);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
