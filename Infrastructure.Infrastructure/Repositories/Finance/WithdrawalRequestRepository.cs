using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Infrastructure.Repositories.Finance;

public class WithdrawalRequestRepository : IWithdrawalRequestRepository
{
    private readonly AppDbContext _context;

    public WithdrawalRequestRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<WithdrawalRequest>> GetByBrandIdAsync(int brandId)
    {
        return await _context.WithdrawalRequests
            .Where(x => x.BrandId == brandId)
            .OrderByDescending(x => x.CreatedAt)
            .ToListAsync();
    }

    public async Task<WithdrawalRequest?> GetByIdAsync(int id)
    {
        return await _context.WithdrawalRequests
            .Include(x => x.Brand)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(WithdrawalRequest request)
    {
        await _context.WithdrawalRequests.AddAsync(request);
    }

    public void Update(WithdrawalRequest request)
    {
        _context.WithdrawalRequests.Update(request);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
