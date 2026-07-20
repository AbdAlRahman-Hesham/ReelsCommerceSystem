using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Entities.Products
{
    public class ProductImage :BaseEntity
    {
        public string Url { get; set; } = null!;
        public string ? PublicId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
