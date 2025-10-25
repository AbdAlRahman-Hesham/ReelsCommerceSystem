using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Domain.Entities.ProductCartEntities
{
    public class ProductCart : BaseEntity
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; } = null!;
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public Cart? Cart { get; set; } = null!;

    }
}
