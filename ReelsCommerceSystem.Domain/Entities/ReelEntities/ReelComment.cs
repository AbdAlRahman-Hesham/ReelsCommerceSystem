using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities;

public class ReelComment : BaseEntity
{
    public string Content { get; set; }
    public int ReelId { get; set; }
    public Reel Reel { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
    public ICollection<ReelCommentLove> Loves { get; set; } = new List<ReelCommentLove>();


}
