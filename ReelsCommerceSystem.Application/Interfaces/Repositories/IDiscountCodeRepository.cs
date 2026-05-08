using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;

namespace ReelsCommerceSystem.Application.Interfaces.Repositories;

public interface IDiscountCodeRepository : IGenericRepository<DiscountCode>
{
    Task<DiscountCode?> GetByCodeAsync(string code);
}
