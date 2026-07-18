using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class OrderTrackingConfig : IEntityTypeConfiguration<OrderTracking>
{
    public void Configure(EntityTypeBuilder<OrderTracking> builder)
    {
        builder.Property(t => t.Status)
               .HasConversion<string>()
               .HasMaxLength(30);
    }
}
