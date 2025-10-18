using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class BrandConfig : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.Property(b => b.DisplayName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(b => b.Description)
            .HasMaxLength(500);

        // Remove Reels configuration - handled in ReelConfig

        builder.HasMany(b => b.Reviews)
            .WithOne(r => r.Brand)
            .HasForeignKey(r => r.BrandId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
