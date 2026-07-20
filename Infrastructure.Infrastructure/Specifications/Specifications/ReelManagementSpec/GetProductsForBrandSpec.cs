using ReelsCommerceSystem.Application.DTOs.Request.ReelManagement;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelManagementSpec
{
    public class GetProductsForBrandSpec : Specification<Product>
    {
        public GetProductsForBrandSpec(int brandId ,GetProductsForBrandReq req)
            : base(p =>
            p.BrandId == brandId &&
            (string.IsNullOrEmpty(req.Search) ||
                p.Name.Contains(req.Search) ||
                (p.Description != null && p.Description.Contains(req.Search)) ||
                (p.ArDescription != null && p.ArDescription.Contains(req.Search)))
        )
        {
           
            if (req.SortByPrice)

                AddOrderBy(p => p.Price);

            else if (req.SortByRating)

                AddOrderByDescending(p => p.Rating);

            else

                AddOrderByDescending(p => p.Id);

            ApplyPaging(req.PageIndex, req.PageSize);


        }
    }
}
