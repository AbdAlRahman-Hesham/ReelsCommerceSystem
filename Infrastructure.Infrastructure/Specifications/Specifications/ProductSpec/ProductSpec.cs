using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Shared.SpecificationsParams;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications;

public class ProductSpec() : Specification<Product>
{

    public ProductSpec(ProductSpecParams productSpecParams):this()
    {
        AddCriteria(p =>
       (string.IsNullOrEmpty(productSpecParams.Search) || p.Name.ToLower().Contains(productSpecParams.Search.ToLower())) &&
       (string.IsNullOrEmpty(productSpecParams.Color) || p.AvailableColors.ToString()!.ToLower() == productSpecParams.Color.ToLower()) &&
       (string.IsNullOrEmpty(productSpecParams.Size) || p.AvailableSizes.ToString().ToLower() == productSpecParams.Size.ToLower()) &&
       (!productSpecParams.MinPrice.HasValue || p.Price >= productSpecParams.MinPrice.Value) &&
       (!productSpecParams.MaxPrice.HasValue || p.Price <= productSpecParams.MaxPrice.Value) &&
       (!productSpecParams.HaveOffer.HasValue || p.HaveOffer == productSpecParams.HaveOffer.Value) &&
       (string.IsNullOrEmpty(productSpecParams.Status) || p.StockStatus.ToString().ToLower() == productSpecParams.Status.ToLower())
   );
        
        AddInclude(p => p.Brand);
        AddInclude(p => p.Category);

        switch (productSpecParams.Sort)
        {
            case "priceAsc":
                AddOrderBy(p => p.Price);
                break;
            case "priceDesc":
                AddOrderByDescending(p => p.Price);
                break;
            case "nameAsc":
                AddOrderBy(p => p.Name);
                break;
            case "nameDesc":
                AddOrderByDescending(p => p.Name);
                break;
            case "newest":
                AddOrderByDescending(p => p.CreatedAt);
                break;
            case "oldest":
                AddOrderBy(p => p.CreatedAt);
                break;
            default:
                AddOrderBy(p => p.Name);
                break;
        }

        if (productSpecParams.PageIndex.HasValue && productSpecParams.PageSize.HasValue)
        {
            var pageIndex = productSpecParams.PageIndex.Value < 1 ? 1 : productSpecParams.PageIndex.Value;
            ApplyPaging(pageIndex, productSpecParams.PageSize.Value);

        }

    }

}
