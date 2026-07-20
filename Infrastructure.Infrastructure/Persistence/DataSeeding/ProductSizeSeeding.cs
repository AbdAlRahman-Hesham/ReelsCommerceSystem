using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Enums;


namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ProductSizeSeeding : IEntityTypeConfiguration<ProductSize>
{
    public void Configure(EntityTypeBuilder<ProductSize> builder)
    {
        builder.HasData(
            new ProductSize { Id = 1, Size = Size.XS },
            new ProductSize { Id = 2, Size = Size.S },
            new ProductSize { Id = 3, Size = Size.M },
            new ProductSize { Id = 4, Size = Size.L },
            new ProductSize { Id = 5, Size = Size.XL },
            new ProductSize { Id = 6, Size = Size.XXL }
        );
    }
}
