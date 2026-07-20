using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;


namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ProductSizeMappingSeeding : IEntityTypeConfiguration<ProductSizeMapping>
{
    int[] availableProductColorMappingIds = Enumerable.Range(1, 182).ToArray();
    int[] availableProductSizeIds = Enumerable.Range(1, 6).ToArray();

    int maxQuantity = 50;
    int minQuantity = 1;

    public void Configure(EntityTypeBuilder<ProductSizeMapping> builder)
    {
        var seedList = new List<ProductSizeMapping>();
        int idCounter = 1;

        foreach (var colorId in availableProductColorMappingIds)
        {
            int sizeCount = (colorId % 6) + 1;

            var sizesForThisColor = availableProductSizeIds.Take(sizeCount);

            foreach (var sizeId in sizesForThisColor)
            {
                int quantity = ((colorId + sizeId) % (maxQuantity - minQuantity + 1)) + minQuantity;

                seedList.Add(new ProductSizeMapping
                {
                    Id = idCounter++,
                    ProductColorMappingId = colorId,
                    ProductSizeId = sizeId,
                    Quantity = quantity
                });
            }
        }

        builder.HasData(seedList);
    }
}