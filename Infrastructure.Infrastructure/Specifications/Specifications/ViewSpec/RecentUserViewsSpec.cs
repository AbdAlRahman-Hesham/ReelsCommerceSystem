using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ViewSpec
{
    public class RecentUserViewsSpec: Specification<UserProductView>
    {
        public RecentUserViewsSpec(string userId, int limit)
         : base(x => x.UserId == userId)
        {
            AddOrderByDescending(x => x.UpdatedAt);
            ApplyPaging(1, limit);
            AddInclude(x => x.User);
            AddInclude(x => x.Product);
            AddInclude("Product.Images");

        }
    }
}
