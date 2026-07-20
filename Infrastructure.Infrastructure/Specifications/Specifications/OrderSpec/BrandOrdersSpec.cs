using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OrderSpec;

public class BrandOrdersSpec : Specification<OrderProduct>
{
    public BrandOrdersSpec(int brandId)
        : base(op => op.BrandId == brandId)
    {
    }
}
