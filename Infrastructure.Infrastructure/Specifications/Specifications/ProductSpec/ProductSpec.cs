using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Enums;
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

            (string.IsNullOrEmpty(productSpecParams.Size) ||
             p.AvailableSizes.Any(asize =>
                 asize.ProductSize.Size.ToString().ToLower() == productSpecParams.Size.ToLower())) &&

            (!productSpecParams.MinPrice.HasValue || p.Price >= productSpecParams.MinPrice.Value) &&
            (!productSpecParams.MaxPrice.HasValue || p.Price <= productSpecParams.MaxPrice.Value) &&

            (!productSpecParams.HaveOffer.HasValue || p.HaveOffer == productSpecParams.HaveOffer.Value) &&

            (string.IsNullOrEmpty(productSpecParams.StockStatus) ||
             p.Status.ToString().ToLower() == productSpecParams.StockStatus.ToLower()) && 

            (string.IsNullOrEmpty(productSpecParams.Category) || p.Category.Name == productSpecParams.Category) &&

            (productSpecParams.BrandId == null || p.BrandId == productSpecParams.BrandId)
        );

        AddIncludes();

        ApplySorting(productSpecParams.SortBy, productSpecParams.SortOrder);

        if (productSpecParams.PageIndex.HasValue && productSpecParams.PageSize.HasValue)
        {
            var pageIndex = productSpecParams.PageIndex.Value < 1 ? 1 : productSpecParams.PageIndex.Value;
            ApplyPaging(pageIndex, productSpecParams.PageSize.Value);
        }
    }

    // Default constructor for fluent API
    public ProductSpec()
    {
        AddIncludes();
    }

    public ProductSpec(int productId) : base(p => p.Id == productId)
    {
        AddIncludes();
    }

    public ProductSpec(string searchTerm) : base(p =>
        p.Name.Contains(searchTerm) ||
        p.Description.Contains(searchTerm) ||
        p.Brand.DisplayName.Contains(searchTerm))
    {
        AddIncludes();
    }

    public ProductSpec(int categoryId, bool includeSubCategories = false)
    {
        if (includeSubCategories)
        {
            // This would need additional logic for category hierarchy
            AddCriteria(p => p.CategoryId == categoryId);
        }
        else
        {
            AddCriteria(p => p.CategoryId == categoryId);
        }
        AddIncludes();
    }

    public ProductSpec(int brandId, int? categoryId = null)
    {
        AddCriteria(p => p.BrandId == brandId);

        if (categoryId.HasValue)
        {
            AddCriteria(p => p.CategoryId == categoryId.Value);
        }

        AddIncludes();
    }

    public ProductSpec(decimal minPrice, decimal maxPrice)
    {
        AddCriteria(p => p.Price >= minPrice && p.Price <= maxPrice);
        AddIncludes();
    }

    public ProductSpec(bool hasOfferOnly)
    {
        AddCriteria(p => p.HaveOffer == hasOfferOnly);
        AddIncludes();
    }

    public ProductSpec(StockStatus stockStatus)
    {
        AddCriteria(p => p.Status == stockStatus);
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
        AddInclude(p => p.AvailableColors);
        AddInclude("AvailableColors.ProductColor");
        AddInclude(p => p.AvailableSizes);
        AddInclude("AvailableSizes.ProductSize");
        AddInclude(p => p.Reviews);
        AddInclude(p => p.ProductInformations);
    }

    // Fluent API methods for building complex queries
    public ProductSpec WithBrand(int brandId)
    {
        AddCriteria(p => p.BrandId == brandId);
        return this;
    }

    public ProductSpec WithCategory(int categoryId)
    {
        AddCriteria(p => p.CategoryId == categoryId);
        return this;
    }

    public ProductSpec WithPriceRange(decimal minPrice, decimal maxPrice)
    {
        AddCriteria(p => p.Price >= minPrice && p.Price <= maxPrice);
        return this;
    }

    public ProductSpec WithOfferOnly()
    {
        AddCriteria(p => p.HaveOffer);
        return this;
    }

    public ProductSpec InStockOnly()
    {
        AddCriteria(p => p.Status == StockStatus.InStock);
        return this;
    }

    public ProductSpec WithSearch(string searchTerm)
    {
        if (!string.IsNullOrEmpty(searchTerm))
        {
            AddCriteria(p => p.Name.Contains(searchTerm) ||
                           p.Description.Contains(searchTerm) ||
                           p.Brand.DisplayName.Contains(searchTerm));
        }
        return this;
    }

    public ProductSpec SortByPrice(bool ascending = true)
    {
        if (ascending)
            AddOrderBy(p => p.Price);
        else
            AddOrderByDescending(p => p.Price);
        return this;
    }

    public ProductSpec SortByName(bool ascending = true)
    {
        if (ascending)
            AddOrderBy(p => p.Name);
        else
            AddOrderByDescending(p => p.Name);
        return this;
    }

    public ProductSpec SortByNewest()
    {
        AddOrderByDescending(p => p.CreatedAt);
        return this;
    }

    public ProductSpec SortByDiscount()
    {
        AddOrderByDescending(p => p.DiscountPercentage ?? 0);
        return this;
    }

    // Static factory methods for common scenarios
    public static ProductSpec ForSearch(string searchTerm) => new ProductSpec(searchTerm);
    public static ProductSpec ForCategory(int categoryId) => new ProductSpec(categoryId);
    public static ProductSpec ForBrand(int brandId) => new ProductSpec(brandId, null);
    public static ProductSpec ForOffers() => new ProductSpec(true);
    public static ProductSpec InStock() => new ProductSpec(StockStatus.InStock);
    public static ProductSpec ById(int productId) => new ProductSpec(productId);
}
