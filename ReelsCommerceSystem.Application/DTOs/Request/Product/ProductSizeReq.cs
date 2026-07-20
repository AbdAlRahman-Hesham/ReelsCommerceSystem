using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Product
{
    public class ProductSizeReq
    {
        public int ProductSizeId { get; set; }
        public int Quantity { get; set; }

    }
}
