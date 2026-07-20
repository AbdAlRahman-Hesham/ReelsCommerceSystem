using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request
{
    public class CreateOfferReq
    {
        public string Description { get; set; } = null!;
        public List<int> ProductIds { get; set; } = new();
        public decimal DiscountPercentage { get; set; }
    }
}
