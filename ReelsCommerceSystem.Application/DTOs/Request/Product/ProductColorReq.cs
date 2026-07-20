using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Product
{
    public class ProductColorReq
    {
        public int ProductColorId { get; set; }
        public List<ProductSizeReq> Sizes { get; set; } = new();
    }
}
