using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.SearchSpec
{
    public class ProductSearchSpec :Specification<Product>
    {
        public ProductSearchSpec(string searchText, int pageIndex, int pageSize)
        : base(criteria: (p => string.IsNullOrEmpty(searchText) ||
                    p.Name.Contains(searchText) ||
                    p.Description.Contains(searchText) ||
                    p.ArDescription.Contains(searchText)))
        {
            AddOrderBy(p => p.Name);

            ApplyPaging(pageIndex, pageSize);
            AddInclude(p => p.Brand);
            AddInclude(p => p.Images);
        }
        public ProductSearchSpec(string searchText)
        : base(criteria: (p => string.IsNullOrEmpty(searchText) ||
                    p.Name.Contains(searchText) ||
                    p.Description.Contains(searchText) ||
                    p.ArDescription.Contains(searchText)))
        {
            AddOrderBy(p => p.Name);

            AddInclude(p => p.Brand);
            AddInclude(p => p.Images);

        }
    }
}
