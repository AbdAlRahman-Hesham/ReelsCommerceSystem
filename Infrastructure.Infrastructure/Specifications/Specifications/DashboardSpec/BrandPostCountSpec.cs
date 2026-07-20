using ReelsCommerceSystem.Domain.Entities.CommunityEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.DashboardSpec;

public class BrandPostCountSpec : Specification<CommunityPost>
{
    public BrandPostCountSpec(int brandId)
        : base(p => p.BrandId == brandId)
    {
    }
}
