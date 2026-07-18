using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;


namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec;

internal class ReelsByBrandWithSortingSpec : Specification<Reel>
{
    public ReelsByBrandWithSortingSpec(int brandId, string? sortBy = null, bool includeDrafts = false)
        : base(criteria: r => r.BrandId == brandId && (includeDrafts || r.Status == ReelStatus.Published))
    {

        if (sortBy == "oldest")
            AddOrderBy(r => r.CreatedAt);

        else if (sortBy == "popular")
            AddOrderByDescending(r => r.CreatedAt); // Client-side sort by NumOfLikes in service

        else
            AddOrderByDescending(r => r.CreatedAt); // default: newest first

        AddInclude(r => r.UserReelLikes);
    }
}

