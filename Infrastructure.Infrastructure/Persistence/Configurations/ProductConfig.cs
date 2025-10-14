using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(P => P.Name).IsRequired()
                                      .HasMaxLength(100);
        builder.Property(P => P.Category).IsRequired();
        builder.Property(P => P.MediaUrl).IsRequired();
        builder.Property(P => P.Price).HasColumnType("decimal(18,2)");

    }
}
