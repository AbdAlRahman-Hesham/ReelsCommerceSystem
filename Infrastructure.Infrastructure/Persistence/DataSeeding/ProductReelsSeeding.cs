using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ProductReelsSeeding : IEntityTypeConfiguration<ProductReels>
{
    int theStartOfAnyIds = 1;
    int numOfBrand = 10;
    int numOfProductsForEachBrand = 6;
    int numOfReelsForEachBrand = 5;
    int minNumOfProductsPerReel = 1;
    int maxNumOfProductsPerReel = 6;
    DateTime createdAt = new DateTime(2025, 12, 2, 0, 0, 0, DateTimeKind.Utc);
    DateTime updatedAt = new DateTime(2025, 12, 2, 0, 0, 0, DateTimeKind.Utc);



    public void Configure(EntityTypeBuilder<ProductReels> builder)
    {
        var data = new List<ProductReels>();
        int idCounter = theStartOfAnyIds;

        for (int brand = 0; brand < numOfBrand; brand++)
        {
            int productStart = (brand * numOfProductsForEachBrand) + 1;
            int productEnd = productStart + numOfProductsForEachBrand - 1;

            int reelStart = (brand * numOfReelsForEachBrand) + 1;
            int reelEnd = reelStart + numOfReelsForEachBrand - 1;

            for (int reelId = reelStart; reelId <= reelEnd; reelId++)
            {
                int productCount =
                    minNumOfProductsPerReel +
                    (reelId % (maxNumOfProductsPerReel - minNumOfProductsPerReel + 1));

                int assigned = 0;
                for (int productId = productStart; productId <= productEnd && assigned < productCount; productId++)
                {
                    data.Add(new ProductReels
                    {
                        Id = idCounter++,
                        ProductId = productId,
                        ReelId = reelId,
                        CreatedAt = createdAt,
                        UpdatedAt = updatedAt
                    });

                    assigned++;
                }
            }
        }

        builder.HasData(data);
    }
}
