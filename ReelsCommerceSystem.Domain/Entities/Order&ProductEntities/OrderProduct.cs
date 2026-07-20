using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.OrderProductEntities;

public class OrderProduct : BaseEntity
{
    public int? ProductId { get; set; }
    public string ProductName { get; set; }
    public Product? Product { get; set; }



    public int BrandId { get; set; }
    public Brand Brand { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; }

    public decimal FinalPrice { get; set; }
    public decimal AppliedDiscountCodeAmount { get; set; }
    public int Quantity { get; set; }

    public string Color { get; set; }

    public Size Size { get; set; }

    public string? MoreDetails { get; set; }

    public bool IsCustomized { get; set; }
    //public string? MediaUrl { get; set; }
    public List<string>? ProductMediaUrls { get; set; } = new();


}