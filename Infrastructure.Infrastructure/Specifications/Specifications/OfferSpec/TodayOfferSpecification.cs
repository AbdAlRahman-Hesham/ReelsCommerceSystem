using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OfferSpec
{
    public class TodayOfferSpecification: Specification<Offer>
    {
        public TodayOfferSpecification()
         : base(o => o.CreatedAt.Date == DateTime.UtcNow.Date)
        {
            AddInclude(o => o.Brand);
            AddInclude(o => o.OfferProducts);
            AddInclude($"{nameof(Offer.OfferProducts)}.{nameof(OfferProduct.Product)}");
        }

    }
}
