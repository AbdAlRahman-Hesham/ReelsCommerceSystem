using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities;

public class UserReelView : BaseEntity
{
    public string UserId { get; set; }
    public User User { get; set; } = null!;

    public int ReelId { get; set; }
    public Reel Reel { get; set; } = null!;

    public int WatchedDurationSeconds { get; set; }

    public int VideoDurationSeconds { get; set; }
    
    [NotMapped]
    public double WatchRatio
    {
        get
        {
            if (VideoDurationSeconds <= 0) return 0.0;
            return Math.Min(1.0, (double)WatchedDurationSeconds / (double)VideoDurationSeconds);
        }
    }

}
