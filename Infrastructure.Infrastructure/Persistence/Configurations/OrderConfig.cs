using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Order> builder)
    {
        builder.Property(o => o.TotalAmount)
             .HasColumnType("decimal(18,2)");

        builder.Property(o => o.DiscountAmount)
             .HasColumnType("decimal(18,2)");

        builder.Property(o => o.OrderStatus)
               .HasConversion<string>()
               .HasMaxLength(20);

        builder.Property(o => o.PaymentStatus)
               .HasConversion<string>()
               .HasMaxLength(20);

        builder.Property(o => o.CancellationRequested)
               .HasDefaultValue(false);

        builder.HasOne(o => o.User)
        .WithMany(u => u.Orders)
        .HasForeignKey(o => o.UserId)
        .OnDelete(DeleteBehavior.NoAction);
    }
}
