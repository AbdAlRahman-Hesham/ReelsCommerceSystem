using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Product
{
    public class OfferProductRes
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public decimal DiscountPercentage { get; set; }

        public decimal DiscountedPrice { get; set; }

        //public string ImageUrl { get; set; } = null!;
        public List<string>? ProductMediaUrls { get; set; } = new();
    }
}
