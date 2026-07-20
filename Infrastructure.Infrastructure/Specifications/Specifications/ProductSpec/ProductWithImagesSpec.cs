using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec
{
    public class ProductWithImagesSpec : Specification<Product>
    {
        public ProductWithImagesSpec(int productId)
        {
            AddCriteria(p => p.Id == productId);
            AddInclude(p => p.Images);
            AsSplitQuery();
        }

    }
}
