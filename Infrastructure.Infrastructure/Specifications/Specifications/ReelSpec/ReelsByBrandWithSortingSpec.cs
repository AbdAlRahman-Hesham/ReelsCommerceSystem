using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;


namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec;

internal class ReelsByBrandWithSortingSpec : Specification<Reel>
{
    public ReelsByBrandWithSortingSpec(int brandId, string? sortBy = null)
        : base(criteria: r => r.BrandId == brandId)
    {
        AddInclude(r => r.Product);

        if (sortBy == "oldest")
            AddOrderBy(r => r.CreatedAt);

        else if (sortBy == "popular")
            AddOrderByDescending(r => r.NumOfLikes);

        else
            AddOrderByDescending(r => r.CreatedAt); // default: newest first
    }
}

