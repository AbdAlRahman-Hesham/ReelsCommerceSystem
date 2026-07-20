using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Product
{
    public class ReelProductRes
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        //public string MediaUrl { get; set; } = null!;
        public List<string>? ProductMediaUrls { get; set; } = new();
        public decimal? DiscountPercentage { get; set; }
        public bool HaveOffer { get; set; }
        public int Rate { get; set; }


    }
}
