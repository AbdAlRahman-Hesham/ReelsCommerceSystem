using ReelsCommerceSystem.Domain.Common;

namespace ReelsCommerceSystem.Domain.Entities.BrandEntities;

public class BrandSocialLink : BaseEntity
{
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;
    public string Platform { get; set; } = null!;
    public string Url { get; set; } = null!;
}
