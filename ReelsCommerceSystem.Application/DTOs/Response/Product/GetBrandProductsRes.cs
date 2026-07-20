using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Product
{
    public class GetBrandProductsRes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public StockStatus Status { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
