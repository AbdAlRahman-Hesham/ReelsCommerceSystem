using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;

public class GetBrandDetailsFullSpec : Specification<Brand>
{
    public GetBrandDetailsFullSpec(int id)
        : base(b => b.Id == id)
    {
        AddIncludeChain(q => q
            .Include(b => b.user)
            .Include(b => b.BrandVerification)
            .Include(b => b.SocialLinks)
            .Include(b => b.UserFollows)
        );
        AsSplitQuery();
    }
}
