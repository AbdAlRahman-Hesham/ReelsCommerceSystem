using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class WithdrawalRequestConfig : IEntityTypeConfiguration<WithdrawalRequest>
{
    public void Configure(EntityTypeBuilder<WithdrawalRequest> builder)
    {
        builder.ToTable("WithdrawalRequests");

        builder.Property(x => x.RequestedAmount).HasColumnType("decimal(18,2)");
        builder.Property(x => x.Notes).HasMaxLength(500);
        builder.Property(x => x.Status).HasConversion<string>().HasMaxLength(30);
        builder.Property(x => x.PaymobTransferId).HasMaxLength(200);

        builder.HasOne(x => x.Brand)
            .WithMany()
            .HasForeignKey(x => x.BrandId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => new { x.BrandId, x.Status });
    }
}
