using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec
{
    public class ProductsByIdsAndBrandSpec : Specification<Product>
    {
        public ProductsByIdsAndBrandSpec(List<int> ids, int brandId)
        {
            AddCriteria(p => ids.Contains(p.Id) && p.BrandId == brandId);
        }
    }
}
