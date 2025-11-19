using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;


namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ProductColorSeeding : IEntityTypeConfiguration<ProductColor>
{
    public void Configure(EntityTypeBuilder<ProductColor> builder)
    {
        builder.HasData(new ProductColor[]
        {
            new ProductColor { Id = 1, Name = "Red", ArName = "أحمر", HexCode = "#FF0000" },
            new ProductColor { Id = 2, Name = "Blue", ArName = "أزرق", HexCode = "#0000FF"},
            new ProductColor { Id = 3, Name = "Green", ArName = "أخضر", HexCode = "#008000" },
            new ProductColor { Id = 4, Name = "Black", ArName = "أسود", HexCode = "#000000"},
            new ProductColor { Id = 5, Name = "White", ArName = "أبيض", HexCode = "#FFFFFF"},
            new ProductColor { Id = 6, Name = "Yellow", ArName = "أصفر", HexCode = "#FFFF00"},
            new ProductColor { Id = 7, Name = "Purple", ArName = "أرجواني", HexCode = "#800080" },
            new ProductColor { Id = 8, Name = "Orange", ArName = "برتقالي", HexCode = "#FFA500"},
            new ProductColor { Id = 9, Name = "Pink", ArName = "وردي", HexCode = "#FFC0CB"},
            new ProductColor { Id = 10, Name = "Gray", ArName = "رمادي", HexCode = "#808080"}
        });

    }
}