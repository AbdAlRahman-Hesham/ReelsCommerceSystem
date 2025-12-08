using ReelsCommerceSystem.Application.DTOs.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Offer
{
    
    public class TodayOffersRes
    {
        public int OfferId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
        public string BrandImage { get; set; } = null!;
        public string OfferImage { get; set; } = null!;
        public string Description { get; set; } = null!;

        public List<OfferProductRes> Products { get; set; } = new();
    }
}
