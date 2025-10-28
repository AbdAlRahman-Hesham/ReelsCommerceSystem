using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;


namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.CartSpec;

public class CartPerUserWithItemWithProductSpec : Specification<Cart>
{
    public CartPerUserWithItemWithProductSpec(string userId) : base(u=>u.UserId==userId)
    {
        AddInclude(c => c.ProductCarts);

    }
}
