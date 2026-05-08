using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities;

public class Reel:BaseEntity
{
    public string VideoUrl { get; set; } = null!;


    public int NumOfLikes => UserReelLikes?.Count ?? 0;
    public int NumOfWatches => UserReelViews?.Count ?? 0;

    public string Title { get; set; } = string.Empty;
    public ReelStatus Status { get; set; } = ReelStatus.Draft;
    public string? ThumbnailUrl { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;
    public ICollection<ProductReels> ProductReels { get; set; } = new List<ProductReels>();
    public ICollection<UserReelLike> UserReelLikes { get; set; } = new List<UserReelLike>();
    public ICollection<UserReelView> UserReelViews { get; set; } = new List<UserReelView>();
    public ICollection<ReelComment> ReelComments { get; set; } = new List<ReelComment>();

}
