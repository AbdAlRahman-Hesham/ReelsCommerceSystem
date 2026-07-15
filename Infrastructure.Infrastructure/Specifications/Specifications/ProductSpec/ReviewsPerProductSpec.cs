using System.Xml.XPath;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;

public class ReviewsPerProductSpec : Specification<ProductReview>
{
    public ReviewsPerProductSpec(int productId) :
        base(
            criteria: p => p.ProductId == productId,
            orderBy: p => p.CreatedAt,
            sortOrder: XmlSortOrder.Descending
        )
    {
        AddInclude(p => p.Product);
        AddInclude(p => p.User);
        AddInclude(p => p.Likes);
        AddInclude(p => p.Dislikes);
    }
}
