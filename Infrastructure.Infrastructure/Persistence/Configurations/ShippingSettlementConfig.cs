using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class ShippingSettlementConfig : IEntityTypeConfiguration<ShippingSettlement>
{
    public void Configure(EntityTypeBuilder<ShippingSettlement> builder)
    {
        builder.ToTable("ShippingSettlements");

        builder.Property(x => x.Amount).HasColumnType("decimal(18,2)");
        builder.Property(x => x.PaymentReference).HasMaxLength(200);
        builder.Property(x => x.Notes).HasMaxLength(500);
        builder.Property(x => x.Status).HasConversion<string>().HasMaxLength(30);

        builder.HasOne(x => x.ShippingCompany)
            .WithMany(s => s.Settlements)
            .HasForeignKey(x => x.ShippingCompanyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Order)
            .WithMany()
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new { x.ShippingCompanyId, x.Status });
    }
}
