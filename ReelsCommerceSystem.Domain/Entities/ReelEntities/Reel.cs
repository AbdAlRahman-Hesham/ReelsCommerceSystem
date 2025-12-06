using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities;

public class Reel:BaseEntity
{
    public string VideoUrl { get; set; } = null!;

    public int NumOfLikes { get; set; } = 0;
    public int NumOfWatches { get; set; } = 0;

    public string Title { get; set; } = string.Empty;

    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;
    public ICollection<ProductReels> ProductReels { get; set; } = new List<ProductReels>();
    public ICollection<UserReelLike> UserReelLikes { get; set; } = new List<UserReelLike>();
    public ICollection<UserReelView> UserReelViews { get; set; } = new List<UserReelView>();
    public ICollection<ReelComment> ReelComments { get; set; } = new List<ReelComment>();

}
