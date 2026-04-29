using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;

public class ProductSpec : Specification<Product>
{
    public ProductSpec(ProductSpecParams productSpecParams) : this()
    {
        // Prepare parsed values for more complex checks (handled outside the expression tree)
        string[]? colors = null;
        if (productSpecParams.Colors != null && productSpecParams.Colors.Any())
        {
            colors = productSpecParams.Colors
                .Select(s => s.Trim().ToLower())
                .ToArray();
        }

        string[]? sizes = null;
        if (productSpecParams.Sizes != null && productSpecParams.Sizes.Any())
        {
            sizes = productSpecParams.Sizes
                .Select(s => s.Trim().ToLower())
                .ToArray();
        }

        // Normalize stock status
        var stockStatusNormalized = string.IsNullOrWhiteSpace(productSpecParams.StockStatus)
            ? null
            : productSpecParams.StockStatus.Replace(" ", "").ToLower();

        // Try parse category as id
        int? categoryId = null;
        if (!string.IsNullOrWhiteSpace(productSpecParams.Category) && int.TryParse(productSpecParams.Category, out var parsedCat))
            categoryId = parsedCat;

        string? searchLower = productSpecParams.Search?.ToLower();
        string? categoryLower = productSpecParams.Category?.ToLower();

        AddCriteria(p =>
            (string.IsNullOrEmpty(productSpecParams.Search) ||
             p.Name.ToLower().Contains(searchLower!) ||
             p.Description.ToLower().Contains(searchLower!) ||
             p.Brand.DisplayName.ToLower().Contains(searchLower!)) &&

            (colors == null || p.AvailableColors.Any(ac =>
                 colors.Contains(ac.ProductColor.Name.ToLower()) ||
                 colors.Contains(ac.ProductColor.ArName.ToLower()))) &&

            (sizes == null || p.AvailableColors.SelectMany(c => c.AvailableSizes)
                                               .Any(s => sizes.Contains(s.ProductSize.Size.ToString().ToLower()))) &&

            (!productSpecParams.MinPrice.HasValue || p.Price >= productSpecParams.MinPrice.Value) &&
            (!productSpecParams.MaxPrice.HasValue || p.Price <= productSpecParams.MaxPrice.Value) &&

            (!productSpecParams.HaveOffer.HasValue || 
                (productSpecParams.HaveOffer.Value 
                    ? (p.DiscountPercentage != null && p.DiscountPercentage > 0) 
                    : (p.DiscountPercentage == null || p.DiscountPercentage <= 0))) &&

            (stockStatusNormalized == null ||
                (stockStatusNormalized == "instock" && p.AvailableColors.Any(ac => ac.AvailableSizes.Any(s => s.Quantity > 0))) ||
                (stockStatusNormalized == "outstock" && !p.AvailableColors.Any(ac => ac.AvailableSizes.Any(s => s.Quantity > 0)))) &&

            (string.IsNullOrEmpty(productSpecParams.Category) ||
                (categoryId.HasValue && p.CategoryId == categoryId.Value) ||
                p.Category.Name.ToLower() == categoryLower ||
                p.Category.ArName.ToLower() == categoryLower) &&

            (productSpecParams.BrandId == null || productSpecParams.BrandId <= 0 || p.BrandId == productSpecParams.BrandId)
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
        AddInclude(p => p.Images);

    }


 
}
