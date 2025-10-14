using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Domain.Entities.AiChatsEntities;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.DisputeEntities;
using ReelsCommerceSystem.Domain.Entities.ForumPostEntities;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Domain.Entities.UserInterestEntities;
using ReelsCommerceSystem.Domain.Entities.UserOrderEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.UserEntities;

public class User : IdentityUser
{
    public string DisplayName { get; set; } = default!;
    public string ImageURL { get; set; } = "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg";
    public Address? Address { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Otp? Otp { get; set; }

    public Role Role { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty; 
    public DateTime? DateOfBirth { get; set; }

    public ICollection<UserOrder> UserOrders { get; set; } = new List<UserOrder>();
    public ICollection<Cart> Carts { get; set; } = new List<Cart>();
    public ICollection<ProductReview> Reviews { get; set; } = new List<ProductReview>();
    public ICollection<ForumPost> ForumPosts { get; set; } = new List<ForumPost>();
    public ICollection<AiChat> AiChats { get; set; } = new List<AiChat>();
    public ICollection<Dispute> Disputes { get; set; } = new List<Dispute>();
    public ICollection<UserInterest> Interests { get; set; } = new List<UserInterest>();
    public ICollection<UserBrandFollow> BrandFollows { get; set; } = new List<UserBrandFollow>();

}
