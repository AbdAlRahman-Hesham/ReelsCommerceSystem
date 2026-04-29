using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;

public class ProductByIdSpec : Specification<Product>
{
    public ProductByIdSpec(int productId)
        : base(p => p.Id == productId)
    {
        AddInclude(p => p.Brand);
        AddInclude(p => p.Category);

        // Include ProductColorMapping
        AddInclude(p => p.AvailableColors);

        // Include ProductColor inside ProductColorMapping
        AddInclude("AvailableColors.ProductColor");

        // Include AvailableSizes inside ProductColorMapping
        AddInclude("AvailableColors.AvailableSizes");

        // Include ProductSize inside AvailableSizes (ProductSizeMapping)
        AddInclude("AvailableColors.AvailableSizes.ProductSize");

        // Reviews + User
        AddInclude(p => p.Reviews);
        AddInclude("Reviews.User");

        // Product Informations
        AddInclude(p => p.ProductInformations);
        AddInclude(p => p.Images);
       
        AddOrderByDescending(p => p.Id);

        AsSplitQuery();

    }
}
