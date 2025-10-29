using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications
{
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

                AddCriteria(p => p.Category != null && p.Category.ToLower() == category.ToLower() && p.Id != excludeProductId);
            }
            AddInclude(p => p.Brand);
            AddOrderByDescending(p => p.CreatedAt);
            ApplyPaging(1, take);
        }
            
        }
    }

