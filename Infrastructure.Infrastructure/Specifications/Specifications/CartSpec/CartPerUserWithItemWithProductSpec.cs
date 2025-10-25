using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductCartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.CartSpec
{
    public class CartPerUserWithItemWithProductSpec : Specification<Cart>
    {
        public CartPerUserWithItemWithProductSpec(string userId) : base(u=>u.UserId==userId)
        {
            AddInclude(c => c.ProductCarts);
            AddInclude(c => c.ProductCarts.Select(ci => ci.Product));

        }
    }
}
