using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;

public class RecentlyAddedProductsSpec : Specification<Product>
{
    public RecentlyAddedProductsSpec(int count)
    {
        AddIncludeChain(q => q.Include(p => p.Brand)
            .ThenInclude(b => b.Reviews));

        AddIncludeChain(q => q.Include(p => p.Category));

        AddIncludeChain(q => q.Include(p => p.Images!));

        AddIncludeChain(q => q.Include(p => p.AvailableColors)
            .ThenInclude(c => c.ProductColor));

        AddIncludeChain(q => q.Include(p => p.AvailableColors)
            .ThenInclude(c => c.AvailableSizes));

        AddIncludeChain(q => q.Include(p => p.Reviews));

        AddOrderByDescending(p => p.CreatedAt);
        ApplyPaging(1, count);
        AsSplitQuery();
    }
}
