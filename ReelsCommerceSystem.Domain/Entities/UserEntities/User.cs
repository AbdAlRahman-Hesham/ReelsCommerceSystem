using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Domain.Entities.AiChatsEntities;
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
    public string ImageURL { get; set; } = string.Empty;
    public Address? Address { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Otp? Otp { get; set; }

    public Role Role { get; set; }

    public ICollection<UserOrder> UserOrders { get; set; } = new List<UserOrder>();
    public ICollection<Cart> Carts { get; set; } = new List<Cart>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<ForumPost> ForumPosts { get; set; } = new List<ForumPost>();
    public ICollection<AiChat> AiChats { get; set; } = new List<AiChat>();
    public ICollection<Dispute> Disputes { get; set; } = new List<Dispute>();
    public ICollection<UserInterest> Interests { get; set; } = new List<UserInterest>();
}
