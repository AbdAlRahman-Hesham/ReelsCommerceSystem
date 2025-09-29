using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.Reviews;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(r => r.Rating)
                .IsRequired();

            builder.Property(r => r.Comment)
                   .HasMaxLength(1000);
        }
    }
}
