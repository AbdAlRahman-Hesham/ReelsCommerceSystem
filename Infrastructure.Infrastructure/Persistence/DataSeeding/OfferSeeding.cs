using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.OfferEntities;

public class OfferSeeding : IEntityTypeConfiguration<Offer>
{
    private static readonly DateTime seedDate = new DateTime(2025, 12, 06, 0, 0, 0, DateTimeKind.Utc);

    public void Configure(EntityTypeBuilder<Offer> builder)
    {
        builder.HasData(
            new Offer
            {
                Id = 1,
                BrandId = 1,
                Description = "Sale 30% on all Product",
                ImageUrl = "https://drive.google.com/file/d/1oaqNd7ONKCa8AFG6myo22H9FWL6nMMaY/view?usp=drive_link",
                CreatedAt = seedDate,
                UpdatedAt = seedDate
            },
            new Offer
            {
                Id = 2,
                BrandId = 3,
                Description = "Buy 2 Get 50% Off",
                ImageUrl = "https://drive.google.com/file/d/1UsBr52J5CZasFrPUbYhsh1q4q1_8L7Y7/view?usp=drive_link",
                CreatedAt = seedDate,
                UpdatedAt = seedDate
            }
        );
    }
}
