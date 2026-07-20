using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.Reviews;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ProductReviewSeeding : IEntityTypeConfiguration<ProductReview>
{
    DateTime _createdAt = new(2025, 11, 9, 12, 0, 0);
    DateTime _updatedAt = new(2025, 11, 9, 12, 0, 0);
    string[] availableUsersIds = ["user1", "user2", "user3", "user4", "user5", "user6", "user7", "user8", "user9", "user10"];
    int[] productsIds = Enumerable.Range(1, 60).ToArray();
    int minRate = 0; // Changed from 0 to 1 since ratings typically start at 1
    int maxRate = 5;
    int minNumberOfReviewers = 3;
    int maxNumberOfReviewers = 10;

    public void Configure(EntityTypeBuilder<ProductReview> builder)
    {
        var reviews = new List<ProductReview>();
        int reviewId = 1;

        foreach (var productId in productsIds)
        {
            // Determine number of reviewers for this product (consistent based on product ID)
            int numberOfReviewers = minNumberOfReviewers + (productId % (maxNumberOfReviewers - minNumberOfReviewers + 1));

            for (int i = 0; i < numberOfReviewers; i++)
            {
                // Deterministic user selection based on product ID and reviewer index
                string userId = availableUsersIds[(productId + i) % availableUsersIds.Length];

                // Deterministic rating based on product ID and reviewer index
                int rating = minRate + ((productId * 7 + i * 13) % (maxRate - minRate + 1));

                // Ensure rating is within bounds
                rating = Math.Clamp(rating, minRate, maxRate);

                reviews.Add(new ProductReview
                {
                    Id = reviewId++,
                    Rating = rating,
                    Comment = $"The product quality is {(rating >= 4 ? "excellent" : rating >= 3 ? "good" : "average")}.",
                    ProductId = productId,
                    UserId = userId,
                    CreatedAt = _createdAt,
                    UpdatedAt = _updatedAt
                });
            }
        }

        builder.HasData(reviews);
    }
}