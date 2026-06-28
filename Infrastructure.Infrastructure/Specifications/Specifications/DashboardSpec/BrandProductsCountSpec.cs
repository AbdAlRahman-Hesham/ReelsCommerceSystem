using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.DashboardSpec;

public class BrandProductsCountSpec : Specification<Product>
{
    public BrandProductsCountSpec(int brandId)
        : base(p => p.BrandId == brandId)
    {
    }
}
