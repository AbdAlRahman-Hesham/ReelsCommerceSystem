using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OfferSpec
{
    public class TodayOfferSpecification: Specification<Offer>
    {
        public TodayOfferSpecification()
         : base(o => o.CreatedAt.Date == DateTime.UtcNow.Date)
        {
            AddInclude(o => o.Brand);
            AddIncludeChain(q => q
                .Include(o => o.OfferProducts)
                    .ThenInclude(op => op.Product)
                        .ThenInclude(p => p.Images));
        }
    }
}
