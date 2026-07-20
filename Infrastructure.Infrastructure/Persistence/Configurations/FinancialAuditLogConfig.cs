using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class FinancialAuditLogConfig : IEntityTypeConfiguration<FinancialAuditLog>
{
    public void Configure(EntityTypeBuilder<FinancialAuditLog> builder)
    {
        builder.ToTable("FinancialAuditLogs");

        builder.Property(x => x.Action).IsRequired().HasMaxLength(100);
        builder.Property(x => x.EntityType).IsRequired().HasMaxLength(50);
        builder.Property(x => x.PerformedBy).HasMaxLength(100);
        builder.Property(x => x.IpAddress).HasMaxLength(50);
        builder.Property(x => x.Notes).HasMaxLength(500);

        builder.HasIndex(x => new { x.EntityType, x.EntityId });
        builder.HasIndex(x => x.Action);
        builder.HasIndex(x => x.CreatedAt);
    }
}
