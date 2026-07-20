using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Infrastructure.Repositories.Finance;

public class FinancialAuditLogRepository : IFinancialAuditLogRepository
{
    private readonly AppDbContext _context;

    public FinancialAuditLogRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(FinancialAuditLog log)
    {
        await _context.FinancialAuditLogs.AddAsync(log);
        await _context.SaveChangesAsync();
    }

    public async Task<(List<FinancialAuditLog> Items, int TotalCount)> GetPagedAsync(AuditLogFilterDto filter)
    {
        var query = _context.FinancialAuditLogs.AsNoTracking().AsQueryable();

        if (!string.IsNullOrWhiteSpace(filter.ActionType))
            query = query.Where(x => x.Action == filter.ActionType);

        if (!string.IsNullOrWhiteSpace(filter.EntityType))
            query = query.Where(x => x.EntityType == filter.EntityType);

        if (!string.IsNullOrWhiteSpace(filter.PerformedBy))
            query = query.Where(x => x.PerformedBy != null && x.PerformedBy.Contains(filter.PerformedBy));

        if (filter.DateFrom.HasValue)
            query = query.Where(x => x.CreatedAt >= filter.DateFrom.Value);

        if (filter.DateTo.HasValue)
            query = query.Where(x => x.CreatedAt <= filter.DateTo.Value.AddDays(1));

        var totalCount = await query.CountAsync();

        var items = await query
            .OrderByDescending(x => x.CreatedAt)
            .Skip((filter.PageIndex - 1) * filter.PageSize)
            .Take(filter.PageSize)
            .ToListAsync();

        return (items, totalCount);
    }
}
