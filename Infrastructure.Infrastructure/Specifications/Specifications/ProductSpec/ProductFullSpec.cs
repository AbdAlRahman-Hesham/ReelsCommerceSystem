using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec
{
    public class ProductFullSpec : Specification<Product>
    {
        public ProductFullSpec(int id)
        {
            AddCriteria(p => p.Id == id);

            AddInclude(p => p.Images);

            AddInclude(p => p.ProductInformations);

            AddIncludeChain(query =>
                query.Include(p => p.AvailableColors)
                     .ThenInclude(c => c.AvailableSizes));
        }
    }
}
