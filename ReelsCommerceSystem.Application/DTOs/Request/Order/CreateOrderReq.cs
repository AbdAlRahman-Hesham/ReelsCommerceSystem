using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Order
{
    public class CreateOrderReq
    {
        public int? AddressId { get; set; }
        public NewAddressDto? Address { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public string? DiscountCode { get; set; }
    }
}
