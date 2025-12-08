using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Entities.OfferEntities
{
    public class Offer : BaseEntity
    {
        public string Description { get; set; } = null!;  
        public string ImageUrl { get; set; } = null!;     
        public int BrandId { get; set; }                  
        public Brand Brand { get; set; } = null!;          

        public ICollection<OfferProduct> OfferProducts { get; set; } = new List<OfferProduct>();
    }
}
