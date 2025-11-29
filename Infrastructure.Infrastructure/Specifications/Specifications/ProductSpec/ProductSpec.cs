using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications;

public class ProductSpec : Specification<Product>
{
    public ProductSpec(ProductSpecParams productSpecParams) : this()
    {
        AddCriteria(p =>
            (string.IsNullOrEmpty(productSpecParams.Search) ||
             p.Name.ToLower().Contains(productSpecParams.Search.ToLower()) ||
             p.Description.ToLower().Contains(productSpecParams.Search.ToLower()) ||
             p.Brand.DisplayName.ToLower().Contains(productSpecParams.Search.ToLower())) &&

            (string.IsNullOrEmpty(productSpecParams.Color) ||
             p.AvailableColors.Any(ac =>
                 ac.ProductColor.Name.ToLower() == productSpecParams.Color.ToLower() ||
                 ac.ProductColor.ArName.ToLower() == productSpecParams.Color.ToLower())) &&

            (string.IsNullOrEmpty(productSpecParams.Size) || p.AvailableColors.SelectMany(c => c.AvailableSizes)
                                                                               .Any(s => s.ProductSize.Size.ToString().ToLower() 
                                                                                         == productSpecParams.Size.ToLower())) &&

            (!productSpecParams.MinPrice.HasValue || p.Price >= productSpecParams.MinPrice.Value) &&
            (!productSpecParams.MaxPrice.HasValue || p.Price <= productSpecParams.MaxPrice.Value) &&

            (!productSpecParams.HaveOffer.HasValue || p.HaveOffer == productSpecParams.HaveOffer.Value) &&

            (string.IsNullOrEmpty(productSpecParams.StockStatus) ||
             p.Status.ToString().ToLower() == productSpecParams.StockStatus.ToLower()) && 

            (string.IsNullOrEmpty(productSpecParams.Category) || p.Category.Name == productSpecParams.Category) &&

            (productSpecParams.BrandId == null || p.BrandId == productSpecParams.BrandId)
        );

        AddIncludes();

        if(!string.IsNullOrEmpty(productSpecParams.SortBy))
        {
            ApplySorting(productSpecParams.SortBy, productSpecParams.SortOrder);
        }
        else
        {
            AddOrderByDescending(p => p.Id);
        }


        if (productSpecParams.PageIndex.HasValue && productSpecParams.PageSize.HasValue)
        {
            var pageIndex = productSpecParams.PageIndex.Value < 1 ? 1 : productSpecParams.PageIndex.Value;
            ApplyPaging(pageIndex, productSpecParams.PageSize.Value);
        }

        AsSplitQuery();
    }

    // Default constructor for fluent API
    public ProductSpec()
    {
        AddIncludes();
    }

 

    


    private void ApplySorting(string? sortBy, string? sortOrder)
    {
        var isDescending = string.Equals(sortOrder, "desc", StringComparison.OrdinalIgnoreCase) ||
                          string.Equals(sortOrder, "descending", StringComparison.OrdinalIgnoreCase);

        // If sortBy is null or empty, use the Sort property as fallback (for backward compatibility)
        if (string.IsNullOrEmpty(sortBy))
        {
            // You might want to check another property here or use default
            AddOrderByDescending(p => p.Id);
            return;
        }

        switch (sortBy.ToLowerInvariant())
        {
            case "name":
                if (isDescending)
                    AddOrderByDescending(p => p.Name);
                else
                    AddOrderBy(p => p.Name);
                break;

            case "price":
                if (isDescending)
                    AddOrderByDescending(p => p.Price);
                else
                    AddOrderBy(p => p.Price);
                break;

            case "createdat":
            case "date":
            case "newest":
                if (isDescending)
                    AddOrderByDescending(p => p.CreatedAt);
                else
                    AddOrderBy(p => p.CreatedAt);
                break;

            case "updatedat":
                if (isDescending)
                    AddOrderByDescending(p => p.UpdatedAt);
                else
                    AddOrderBy(p => p.UpdatedAt);
                break;

            case "discount":
                if (isDescending)
                    AddOrderByDescending(p => p.DiscountPercentage ?? 0);
                else
                    AddOrderBy(p => p.DiscountPercentage ?? 0);
                break;

            case "popularity":
                // This would need additional logic for popularity calculation
                if (isDescending)
                    AddOrderByDescending(p => p.Reviews.Count);
                else
                    AddOrderBy(p => p.Reviews.Count);
                break;

            case "rating":
                // This would need additional logic for average rating calculation
                if (isDescending)
                    AddOrderByDescending(p => p.Reviews.Average(r => r.Rating));
                else
                    AddOrderBy(p => p.Reviews.Average(r => r.Rating));
                break;

            default:
                // Default sorting by creation date (newest first)
                AddOrderByDescending(p => p.Id);
                break;
        }
    }


    private void AddIncludes()
    {
        AddInclude(p => p.Brand);
        AddInclude(p => p.Category);

        // Include ProductColorMapping
        AddInclude(p => p.AvailableColors);

        // Include ProductColor inside ProductColorMapping
        AddInclude("AvailableColors.ProductColor");

        // Include AvailableSizes inside ProductColorMapping
        AddInclude("AvailableColors.AvailableSizes");

        // Include ProductSize inside AvailableSizes (ProductSizeMapping)
        AddInclude("AvailableColors.AvailableSizes.ProductSize");

        // Reviews + User
        AddInclude(p => p.Reviews);

        // Product Informations
        AddInclude(p => p.ProductInformations);

    }


 
}
