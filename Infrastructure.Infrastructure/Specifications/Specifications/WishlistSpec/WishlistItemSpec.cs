using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.WishlistSpec;

public class WishlistItemSpec : Specification<WishlistItem>
{
    public WishlistItemSpec(string userId,int productId) : base
        (
        criteria: (item => item.UserId == userId && item.ProductId == productId)
        )
    {
        AddInclude(w => w.Product);
    }
    public WishlistItemSpec(string userId) : base
        (
        criteria: (item => item.UserId == userId),
        orderBy: item => item.CreatedAt,
        sortOrder: XmlSortOrder.Descending
        )
    {
        AddInclude(w => w.Product);
        AddInclude(w => w.Product.Category);
        AddInclude(w => w.Product.Brand);
    }


}
