using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Product
{
    public class ProductPag
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
        public string MediaUrl { get; set; } = null!;
        public string? Color { get; set; }
        public string? Size { get; set; }
        public bool HaveOffer { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public string? Status { get; set; }
        public string BrandName { get; set; } = null!;
    }
}
