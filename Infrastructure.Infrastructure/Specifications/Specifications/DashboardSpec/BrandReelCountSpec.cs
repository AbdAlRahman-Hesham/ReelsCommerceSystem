using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.DashboardSpec;

public class BrandReelCountSpec : Specification<Reel>
{
    public BrandReelCountSpec(int brandId)
        : base(r => r.BrandId == brandId)
    {
    }
}
