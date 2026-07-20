using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Infrastructure.Repositories;

public class DiscountCodeRepository(AppDbContext context) : GenericRepository<DiscountCode>(context), IDiscountCodeRepository
{
    private readonly AppDbContext _context = context;

    public async Task<DiscountCode?> GetByCodeAsync(string code)
    {
        return await _context.DiscountCodes
            .FirstOrDefaultAsync(d => d.Code == code);
    }
}
