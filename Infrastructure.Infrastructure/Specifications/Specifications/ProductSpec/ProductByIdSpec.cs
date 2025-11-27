using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications;

public class ProductByIdSpec : Specification<Product>
{
    public ProductByIdSpec(int productId)
        : base(p => p.Id == productId)
    {
        AddInclude(p => p.Brand);
        AddInclude(p => p.Category);
        AddInclude(p => p.AvailableColors);
        AddInclude("AvailableColors.ProductColor");
        AddInclude("AvailableSizes.ProductSize");
        AddInclude(p => p.Reviews);
        AddInclude("Reviews.User");
        AddInclude(p => p.ProductInformations);
    }
}
