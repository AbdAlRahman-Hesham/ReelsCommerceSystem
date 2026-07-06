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
}
