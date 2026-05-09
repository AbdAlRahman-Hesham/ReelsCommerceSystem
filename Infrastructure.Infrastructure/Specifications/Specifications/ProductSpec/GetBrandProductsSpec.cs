
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec
{
    public class GetBrandProductsSpec : Specification<Product>
    {
        public GetBrandProductsSpec(GetBrandProductsParams param, int brandId)
        {
            AddCriteria(p =>
                p.BrandId == brandId &&

                (!param.CategoryId.HasValue || p.CategoryId == param.CategoryId) &&

                (!param.MinPrice.HasValue || p.Price >= param.MinPrice) &&
                (!param.MaxPrice.HasValue || p.Price <= param.MaxPrice) &&

                (!param.Status.HasValue || p.Status == param.Status)
            );

            AddInclude(p => p.Images);

            AddIncludeChain(query =>
           query.Include(p => p.AvailableColors)
                .ThenInclude(c => c.AvailableSizes));

            AddOrderByDescending(p => p.CreatedAt);

            ApplyPaging(param.PageIndex, param.PageSize);

            AsSplitQuery();
        }
    }
}
