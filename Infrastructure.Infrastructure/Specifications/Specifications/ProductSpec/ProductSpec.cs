using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Shared.SpecificationsParams;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications;

public class ProductSpec(ProductSpecParams productSpecParams) : Specification<Product>
    (
    criteria: p=> p.Quantity == productSpecParams.Quantity,
    includes: null,
    orderBy: null,
    sortOrder: XmlSortOrder.Ascending,
    pageSize: 3,
    pageIndex:2
    )
{
    
}
