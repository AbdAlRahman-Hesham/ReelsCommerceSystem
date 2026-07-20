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
        //builder.Property(P => P.MediaUrl).IsRequired();
        builder.Property(P => P.Price).HasColumnType("decimal(18,2)");
        builder.Property(p => p.DiscountPercentage).HasPrecision(5, 2);

        builder.HasOne(p => p.Category)
              .WithMany(c => c.Products)
              .HasForeignKey(p => p.CategoryId)
              .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(p => p.AvailableColors)
            .WithOne(c => c.Product)
            .HasForeignKey(c=>c.ProductId);
        builder.HasMany(p => p.Images)
           .WithOne(i => i.Product)
           .HasForeignKey(i => i.ProductId)
           .OnDelete(DeleteBehavior.Cascade);

    }
}
