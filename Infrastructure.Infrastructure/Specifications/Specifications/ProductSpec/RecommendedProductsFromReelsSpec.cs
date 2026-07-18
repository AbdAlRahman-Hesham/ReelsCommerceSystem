using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;

public class RecommendedProductsFromReelsSpec : Specification<Reel>
{
    public RecommendedProductsFromReelsSpec(List<int> reelIds)
        : base(criteria: r => reelIds.Contains(r.Id))
    {
        AddIncludeChain(q => q.Include(r => r.ProductReels)
            .ThenInclude(pr => pr.Product)
            .ThenInclude(p => p!.Brand));

        AddIncludeChain(q => q.Include(r => r.ProductReels)
            .ThenInclude(pr => pr.Product)
            .ThenInclude(p => p!.Category));

        AddIncludeChain(q => q.Include(r => r.ProductReels)
            .ThenInclude(pr => pr.Product)
            .ThenInclude(p => p!.Images!));

        AddIncludeChain(q => q.Include(r => r.ProductReels)
            .ThenInclude(pr => pr.Product)
            .ThenInclude(p => p!.AvailableColors)
            .ThenInclude(c => c.ProductColor));

        AddIncludeChain(q => q.Include(r => r.ProductReels)
            .ThenInclude(pr => pr.Product)
            .ThenInclude(p => p!.Reviews));

        AsSplitQuery();
    }
}
