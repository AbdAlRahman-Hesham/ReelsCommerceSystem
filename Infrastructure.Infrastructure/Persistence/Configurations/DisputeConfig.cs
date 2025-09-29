using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.DisputeEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class DisputeConfig : IEntityTypeConfiguration<Dispute>
    {
        public void Configure(EntityTypeBuilder<Dispute> builder)
        {
            builder.Property(d => d.Reason)
                 .IsRequired()
                 .HasMaxLength(500);

            builder.Property(d => d.Status)
                   .HasConversion<string>()
                   .HasMaxLength(20);
        }
    }
}
