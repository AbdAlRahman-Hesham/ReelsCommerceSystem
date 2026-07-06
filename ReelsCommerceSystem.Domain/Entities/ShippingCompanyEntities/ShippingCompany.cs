using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;

namespace ReelsCommerceSystem.Domain.Entities.ShippingCompanyEntities;

public class ShippingCompany : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? ContactEmail { get; set; }
    public string? ContactPhone { get; set; }
    public string? UserId { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<ShippingSettlement> Settlements { get; set; } = new List<ShippingSettlement>();
}
