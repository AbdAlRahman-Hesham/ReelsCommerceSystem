using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications;

public class RelatedProductsSpec:Specification<Product>
{
    public RelatedProductsSpec(string category, int excludeProductId, int take = 3):base()
    {
        if (string.IsNullOrEmpty(category))
        {
            AddCriteria(p => p.Id != excludeProductId);
        }
        else
        {

            AddCriteria(p => p.Category != null && p.Category.Name.ToLower() == category.ToLower() && p.Id != excludeProductId);
        }
        AddInclude(p => p.Brand);
        AddInclude(p => p.Category);
        AddOrderByDescending(p => p.CreatedAt);
        ApplyPaging(1, take);
    }
        
    }


