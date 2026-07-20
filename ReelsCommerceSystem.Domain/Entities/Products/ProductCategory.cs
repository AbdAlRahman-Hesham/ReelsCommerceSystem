using ReelsCommerceSystem.Domain.Common;

namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class ProductCategory : BaseEntity
{
    public string Name { get; set; } = null!;
    public string ArName { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string? ImagePublicId { get; set; }
    public virtual ICollection<Product> Products{ get; set; } = new List<Product>();

}
