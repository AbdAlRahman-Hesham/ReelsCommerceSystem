using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelManagementSpec
{
    public class GetProductsByIdsForBrandSpec :Specification<Product>
    {
        public GetProductsByIdsForBrandSpec(List<int> productIds ,int brandId)
            :base(p => productIds.Contains(p.Id) && p.BrandId == brandId)
        {
            
        }
    }
}
