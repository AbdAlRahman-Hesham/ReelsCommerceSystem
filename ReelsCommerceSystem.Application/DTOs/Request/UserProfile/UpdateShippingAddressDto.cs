using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.UserProfile
{
    public class UpdateShippingAddressDto
    {
        public string? Name { get; set; }
        public string? Postcode { get; set; }
        public string? Country { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }

        [RegularExpression(@"^\+20(10|11|12|15)\d{8}$")]
        public string? PhoneNumber { get; set; }

        public bool? IsDefault { get; set; }
    }
}
