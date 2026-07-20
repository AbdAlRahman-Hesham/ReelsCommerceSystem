using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class BrandSettlementConfig : IEntityTypeConfiguration<BrandSettlement>
{
    public void Configure(EntityTypeBuilder<BrandSettlement> builder)
    {
        builder.ToTable("BrandSettlements");

        builder.Property(x => x.GrossAmount).HasColumnType("decimal(18,2)");
        builder.Property(x => x.PlatformCommission).HasColumnType("decimal(18,2)");
        builder.Property(x => x.NetAmount).HasColumnType("decimal(18,2)");
        builder.Property(x => x.PaymentReference).HasMaxLength(200);
        builder.Property(x => x.Notes).HasMaxLength(500);
        builder.Property(x => x.TransferId).HasMaxLength(200);
        builder.Property(x => x.Status).HasConversion<string>().HasMaxLength(30);

        builder.HasOne(x => x.Brand)
            .WithMany()
            .HasForeignKey(x => x.BrandId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Order)
            .WithMany()
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new { x.BrandId, x.Status });
    }
}
