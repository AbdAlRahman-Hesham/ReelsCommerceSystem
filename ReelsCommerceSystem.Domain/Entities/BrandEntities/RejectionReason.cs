using ReelsCommerceSystem.Domain.Common;


namespace ReelsCommerceSystem.Domain.Entities.BrandEntities
{
    public class RejectionReason : BaseEntity
    {
        public string Code { get; set; } = null!;
        public string Description { get; set; }
        public ICollection<Brand> Brands { get; set; } = new List<Brand>();
    }
}
