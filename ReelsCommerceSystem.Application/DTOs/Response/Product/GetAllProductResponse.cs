using System.Text.Json.Serialization;

namespace ReelsCommerceSystem.Application.DTOs.Response.Product;

public class GetAllProductsResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? ArDescription { get; set; }
    public decimal Price { get; set; }
    public bool HaveOffer { get; set; }
    public decimal? DiscountedPrice
    {
        get
        {
            if (DiscountPercentage.HasValue && DiscountPercentage > 0)
            {
                return Price - (Price * DiscountPercentage.Value / 100);
            }
            return null;
        }
    }
    public decimal? DiscountPercentage { get; set; }
    public int Quantity { get; set; }
    public string MediaUrl { get; set; } = null!;
    public List<string> MediaUrls { get; set; } = new();
    public bool IsCustomizable { get; set; }
    public string StockStatus { get; set; }

    public ProductBrandDto? Brand { get; set; } = null!;
    public ProductCategoryDto? Category { get; set; } = null!;
    public ProductReviewsSummaryDto? ReviewsSummary { get; set; } = new();
    public bool IsInWishlist { get; set; }  // TODO: Set this property based on user's wishlist
    [JsonPropertyOrder(100)]
    public List<ProductColorDto> AvailableColors { get; set; } = new();
}


public class ProductBrandDto
{
    public int Id { get; set; }
    public string DisplayName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string LogoUrl { get; set; } = null!;
    public int FollowersCount { get; set; }
    public double? AverageRating { get; set; }
}

public class ProductCategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string ArName { get; set; } = null!;
}

public class ProductColorDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string ArName { get; set; } = null!;
    public string HexCode { get; set; } = null!;
    public int Quantity { get; set; }

    public List<ProductSizeDto> AvailableSizes { get; set; } = new();
}

public class ProductSizeDto
{
    public int Id { get; set; }
    public string Size { get; set; }
    public int Quantity { get; set; }
}

public class ProductInformationDto
{
    public int Id { get; set; }
    public string Key { get; set; } = null!;
    public string Value { get; set; } = null!;
    public string? ArKey { get; set; }
    public string? ArValue { get; set; }
    public string Type { get; set; }
    public string? Group { get; set; }
    public string? ArGroup { get; set; }
    public int DisplayOrder { get; set; }
}

public class ProductReviewsSummaryDto
{
    public double AverageRating { get; set; }
    public int TotalReviews { get; set; }
    public Dictionary<int, int> RatingDistribution { get; set; } = new()
    {
        { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }
    };
}

public class ProductReviewDto
{
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public UserDto User { get; set; } = null!;
}

public class UserDto
{
    public string Id { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string? ProfilePictureUrl { get; set; }
}
