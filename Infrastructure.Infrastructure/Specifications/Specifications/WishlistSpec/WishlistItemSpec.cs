using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.WishlistSpec
{
    public class WishlistItemSpec : Specification<WishlistItem>
    {
        public WishlistItemSpec(string userId,int productId) : base
            (
            criteria: (item => item.UserId == userId && item.ProductId == productId)
            )
        {
        }
        public WishlistItemSpec(string userId) : base
            (
            criteria: (item => item.UserId == userId),
            includes: [item => item.Product,item=>item.Product.Brand],
            orderBy: item => item.CreatedAt,
            sortOrder: XmlSortOrder.Descending
            )
        {
        }


    }
}
