using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications;

public class ReviewsPerBrandSpec : Specification<BrandReview>
{
    public ReviewsPerBrandSpec(int brandId):
        base(
            criteria: p => p.BrandId == brandId,
            includes: [p => p.Brand, p=>p.User],
            orderBy: p => p.CreatedAt,
            sortOrder: XmlSortOrder.Descending
        )
    {

    }
}