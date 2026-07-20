using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities;

public class ReelCommentLove : BaseEntity
{
    public int ReelCommentId { get; set; }
    public ReelComment ReelComment { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
}