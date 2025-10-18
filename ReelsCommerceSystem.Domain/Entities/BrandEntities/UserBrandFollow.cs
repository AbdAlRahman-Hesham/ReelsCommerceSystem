using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.BrandEntities;

public class UserBrandFollow: BaseEntity
{
    public string UserId { get; set; } = default!;
    public User User { get; set; } = default!;

    public int BrandId { get; set; }
    public Brand Brand { get; set; } = default!;

    public DateTime FollowedAt { get; set; } = DateTime.UtcNow;
}
