using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OfferSpec
{
    public class RecentOffersSpecification : Specification<Offer>
    {
        public RecentOffersSpecification(int takeN) : base(o => true)
        {
            AddInclude(o => o.Brand);
            AddIncludeChain(q => q
                .Include(o => o.OfferProducts)
                    .ThenInclude(op => op.Product)
                        .ThenInclude(p => p.Images));
            
            AddOrderByDescending(o => o.CreatedAt);
            ApplyPaging(1, takeN);
        }
    }
}
