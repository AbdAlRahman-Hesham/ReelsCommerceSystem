using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;


namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec
{
    internal class ReelsByBrandWithSortingSpec : Specification<Reel>
    {
        public ReelsByBrandWithSortingSpec(int brandId, string? SortBy = null)
            : base(criteria: r => r.BrandId == brandId,
                   includes: [r => r.Product])
        {
            {

                if (SortBy == "oldest")
                    AddOrderBy(r => r.CreatedAt);
                else if (SortBy == "popular")
                    AddOrderByDescending(r => r.NumOfLikes);
            }
        }
    }
}
