using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;

public class BrandListSpec : Specification<Brand>
{
    public BrandListSpec(BrandSpecParams specParams) : this()
    {
        string? searchLower = specParams.Search?.ToLower();

        AddCriteria(b =>
            b.Status == BrandStatus.APPROVED &&
            (string.IsNullOrEmpty(specParams.Search) ||
             b.DisplayName.ToLower().Contains(searchLower!) ||
             b.Description.ToLower().Contains(searchLower!) ||
             b.Category.ToLower().Contains(searchLower!)) &&
            (string.IsNullOrEmpty(specParams.CategoryName) ||
             b.Category == specParams.CategoryName)
        );

        AddOrderByDescending(b => b.Id);

        if (specParams.PageIndex.HasValue && specParams.PageSize.HasValue)
        {
            var pageIndex = specParams.PageIndex.Value < 1 ? 1 : specParams.PageIndex.Value;
            ApplyPaging(pageIndex, specParams.PageSize.Value);
        }
    }

    public BrandListSpec()
    {
    }
}
