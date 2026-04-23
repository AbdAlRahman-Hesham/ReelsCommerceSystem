using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Domain.Entities.UserInterestEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.UserEntities;

public class User : IdentityUser
{
    public string DisplayName { get; set; } = default!;
    public string ImageURL { get; set; } = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg";
    public bool IsBrandOwner => Brand != null;
    public ICollection<Address> ShippingAddresses { get; set; } = new List<Address>();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Otp? Otp { get; set; }

    public Role Role { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty; 
    public DateTime? DateOfBirth { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<ProductReview> Reviews { get; set; } = new List<ProductReview>();
    public ICollection<UserInterest> Interests { get; set; } = new List<UserInterest>();
    public ICollection<UserBrandFollow> BrandFollows { get; set; } = new List<UserBrandFollow>();
    public virtual ICollection<WishlistItem>? WishlistItems { get; set; } = new HashSet<WishlistItem>();
    public ICollection<UserReelLike> UserReelLikes { get; set; } = new List<UserReelLike>();
    public ICollection<UserReelView> UserReelViews { get; set; } = new List<UserReelView>();
    public ICollection<ReelComment> ReelComments { get; set; } = new List<ReelComment>();
    public ICollection<ReelCommentLove> ReelCommentLoves { get; set; } = new List<ReelCommentLove>();
    public ICollection<ReelCommentReplyLove> reelCommentReplyLoves { get; set; }
    public ICollection<UserProductView> UserProductViews { get; set; } = new List<UserProductView>();
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    public Brand? Brand { get; set; }

    public bool IsBanned { get; set; } = false;
}
