using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class ProductSizeConfig : IEntityTypeConfiguration<ProductSize>
{
    public void Configure(EntityTypeBuilder<ProductSize> builder)
    {
        builder.HasMany(ps => ps.Products).WithOne(p=>p.ProductSize);
        builder.Property(ps => ps.Size).HasConversion<string>();
    }
}
