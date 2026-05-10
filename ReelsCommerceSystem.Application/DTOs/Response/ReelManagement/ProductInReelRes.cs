using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.ReelManagement
{
    public class ProductInReelRes
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ArDescription { get; set; }
        public int Rating { get; set; } = 0;//for now

        public string StockStatus { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
