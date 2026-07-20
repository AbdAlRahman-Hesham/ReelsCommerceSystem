using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec
{
    public class GetBrandProductCountSpec : Specification<Product>
    {
        public GetBrandProductCountSpec(GetBrandProductsParams param, int brandId)
        {
            string? searchLower = param.Search?.ToLower();

            var statusNormalized = string.IsNullOrWhiteSpace(param.Status)
                ? null
                : param.Status.Replace(" ", "").ToLower() switch
                {
                    "0" or "" => null,
                    "1" or "instock" or "in_stock" => "instock",
                    "2" or "outstock" or "out_of_stock" => "outstock",
                    _ => null
                };

            AddCriteria(p =>
                p.BrandId == brandId &&

                (string.IsNullOrEmpty(param.Search) ||
                 p.Name.ToLower().Contains(searchLower!) ||
                 p.Description.ToLower().Contains(searchLower!)) &&

                (!param.CategoryId.HasValue || p.CategoryId == param.CategoryId) &&

                (!param.MinPrice.HasValue || p.Price >= param.MinPrice) &&
                (!param.MaxPrice.HasValue || p.Price <= param.MaxPrice) &&

                (statusNormalized == null ||
                    (statusNormalized == "instock" && p.AvailableColors.Any(ac => ac.AvailableSizes.Any(s => s.Quantity > 0))) ||
                    (statusNormalized == "outstock" && !p.AvailableColors.Any(ac => ac.AvailableSizes.Any(s => s.Quantity > 0))))
            );
        }
    }
}
