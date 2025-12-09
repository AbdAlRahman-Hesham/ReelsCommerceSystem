using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Search
{
    public class ProductSearchRes
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ArDescription { get; set; }
        public decimal Price { get; set; }
        public string MainImageUrl { get; set; }
    }
}
