using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Order
{
    public class NewAddressDto
    {
        public string Name { get; set; }
        public string? ShippingLastName { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string? ShippingBuilding { get; set; }
        public string? ShippingFloor { get; set; }
        public string? ShippingApartment { get; set; }
        public bool SaveAddress { get; set; } = false;
        public bool SetAsDefault { get; set; } = false;
    }
}
