using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities;

public class UserReelLike : BaseEntity
{
    public string UserId { get; set; }
    public User User { get; set; } = null!;
    public int ReelId { get; set; }
    public Reel Reel { get; set; } = null!;
}