using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding
{
    public class OfferProductSeeding : IEntityTypeConfiguration<OfferProduct>
    {
        public void Configure(EntityTypeBuilder<OfferProduct> builder)
        {
            builder.HasData(
                new OfferProduct { OfferId = 1, ProductId = 1 },
                new OfferProduct { OfferId = 1, ProductId = 2 },
                new OfferProduct { OfferId = 2, ProductId = 14 }
            );
        }
    }

}
