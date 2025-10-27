using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Wishlist
{
    public class WishlistProductRes
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public string BrandName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
