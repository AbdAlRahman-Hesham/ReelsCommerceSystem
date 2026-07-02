using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.OrderEntities;

public class Order : BaseEntity
{
    public DateTime? DeleviredDate { get; set; }
    public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
    public decimal TotalAmount { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;
    public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.NotSpecified;

    public string UserId { get; set; }
    public User User { get; set; }

    public string ShippingName { get; set; }
    public string ShippingLastName { get; set; } // جديد
    public string ShippingStreet { get; set; }
    public string ShippingBuilding { get; set; } // جديد
    public string ShippingFloor { get; set; } // جديد
    public string ShippingApartment { get; set; } // جديد
    public string ShippingCity { get; set; }
    public string ShippingCountry { get; set; }
    public string ShippingPostalCode { get; set; }
    public string ShippingPhoneNumber { get; set; }

    public DeliveryMethod DeliveryMethod { get; set; }
    public decimal DiscountAmount { get; set; }
    public int? DiscountCodeId { get; set; }
    public DiscountCode? DiscountCode { get; set; }

    public OrderTracking? Tracking { get; set; }

    public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public int? PaymobOrderId { get; set; }
    public string? PaymobTransactionId { get; set; }
    public DateTime? PaidAt { get; set; }

    public bool CancellationRequested { get; set; } = false;
}
