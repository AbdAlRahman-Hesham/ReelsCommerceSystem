using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class OrderProductConfig : IEntityTypeConfiguration<OrderProduct>
{
    public void Configure(EntityTypeBuilder<OrderProduct> builder)
    {

        builder.Property(op => op.FinalPrice).HasColumnType("decimal(18,2)");
        builder
            .Property(op => op.Size)
            .HasConversion(s => s.ToString(), s => (Size)Enum.Parse(typeof(Size), s));
    }
}
