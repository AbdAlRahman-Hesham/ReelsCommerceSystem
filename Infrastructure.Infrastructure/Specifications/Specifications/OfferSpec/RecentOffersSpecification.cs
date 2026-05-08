using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OfferSpec
{
    public class RecentOffersSpecification : Specification<Offer>
    {
        public RecentOffersSpecification(int takeN) : base(o => true)
        {
            AddInclude(o => o.Brand);
            AddInclude(o => o.OfferProducts);
            AddInclude($"{nameof(Offer.OfferProducts)}.{nameof(OfferProduct.Product)}");
            
            AddOrderByDescending(o => o.CreatedAt);
            ApplyPaging(1, takeN);
        }
    }
}
