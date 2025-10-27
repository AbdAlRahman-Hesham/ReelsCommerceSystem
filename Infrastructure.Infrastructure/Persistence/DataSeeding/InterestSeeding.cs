using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.InterestEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding
{
    public class InterestSeeding : IEntityTypeConfiguration<Interest>
    {
        public void Configure(EntityTypeBuilder<Interest> builder)
        {
            builder.HasData(

                    new Interest { Id = 1, Name = "Fashion" },
                    new Interest { Id = 2, Name = "Makeup" },
                    new Interest { Id = 3, Name = "Shoes" },
                    new Interest { Id = 4, Name = "Candles" },
                    new Interest { Id = 5, Name = "Perfumes" },
                    new Interest { Id = 6, Name = "Jewelry" },
                    new Interest { Id = 7, Name = "Accessories" },
                    new Interest { Id = 8, Name = "Travel" },
                    new Interest { Id = 9, Name = "Bags" },
                    new Interest { Id = 10, Name = "Handmade Crafts" }
                );
        }
    }
}
