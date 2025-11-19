using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities;

public class Reel:BaseEntity
{
    public string VideoUrl { get; set; } = null!;
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public int NumOfLikes { get; set; }
    public int NumOfWatches { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;
}
