using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;

namespace ReelsCommerceSystem.Domain.Entities.BrandEntities;

public class Brand:BaseEntity
{
    public string DisplayName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string LogoUrl { get; set; } = null!;
    public string VerificationStatus { get; set; } = null!;
    public string ReturnPolicyAsHtml { get; set; } = null!;
    public ICollection<Product> Products { get; set; } = new List<Product>();
    public ICollection<UserBrandFollow> UserFollows { get; set; } = new List<UserBrandFollow>();
    public ICollection<BrandReview> Reviews { get; set; } = new List<BrandReview>();
    public ICollection<Reel> Reels { get; set; } = new List<Reel>();

}
