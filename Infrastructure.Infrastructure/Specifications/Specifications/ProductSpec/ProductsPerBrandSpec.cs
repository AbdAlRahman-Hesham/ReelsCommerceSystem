using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications;

public class ProductsPerBrandSpec : Specification<Product>
{
    public ProductsPerBrandSpec(ProductsPerBrandSpecParams productsPerBrandSpecParams) : 
        base(
            criteria: p => p.BrandId == productsPerBrandSpecParams.BrandId &&
                (!productsPerBrandSpecParams.IsOffered || (p.DiscountPercentage != null && p.DiscountPercentage > 0)),
            includes: [p => p.Brand],
            orderBy: p => p.Price,
            sortOrder: XmlSortOrder.Ascending
            )
    {
    }
}
