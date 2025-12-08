using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Entities.OfferEntities
{
    public class OfferProduct
    {
        public int OfferId { get; set; }
        public Offer Offer { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }

}
