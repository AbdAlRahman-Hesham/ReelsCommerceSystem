using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec
{
    public class ProductsForOrderSpec : Specification<Product>
    {
        public ProductsForOrderSpec(List<int> ids)
        : base(p => ids.Contains(p.Id))
        {
            AddInclude(p => p.AvailableColors);
            AsSplitQuery();
        }
    }
}
