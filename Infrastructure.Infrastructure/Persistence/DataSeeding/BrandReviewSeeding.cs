using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class BrandReviewSeeding : IEntityTypeConfiguration<BrandReview>
{
    private static readonly DateTime _staticSeedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    public void Configure(EntityTypeBuilder<BrandReview> builder)
    {
        var reviews = new List<BrandReview>();
        var reviewId = 1;

        var userIds = new List<string>
        {
            "user1", "user2", "user3", "user4", "user5",
            "user6", "user7", "user8", "user9", "user10"
        };

        var reviewComments = new Dictionary<int, List<(string Comment, int Rating)>>
        {
            [1] = new List<(string, int)>
            {
                ("Love their sustainable approach! The quality is amazing and the materials feel premium. Definitely worth the price.", 5),
                ("Good products but shipping took longer than expected. The eco-friendly packaging was a nice touch though.", 4),
                ("The clothes are comfortable and stylish. Happy to support a brand that cares about the environment.", 5)
            },
            [2] = new List<(string, int)>
            {
                ("Their charging dock is a game-changer! Charges all my devices simultaneously without overheating.", 5),
                ("Decent products but customer service could be better. Had an issue with my order resolution.", 3),
                ("The smart accessories are innovative and well-designed. Perfect for my tech-heavy lifestyle.", 4)
            },
            [3] = new List<(string, int)>
            {
                ("The serum transformed my skin! Natural ingredients actually work. My skin has never looked better.", 5),
                ("Products are good but a bit pricey for the quantity. The results are noticeable though.", 4),
                ("Had an allergic reaction to one product. Customer service was helpful with the return.", 2)
            },
            [4] = new List<(string, int)>
            {
                ("Best streetwear brand out there! The hoodies are super comfortable and the designs are unique.", 5),
                ("Quality is good but sizes run small. Make sure to order a size up for the perfect fit.", 4),
                ("Love their style! The jackets are my favorite - perfect for urban fashion enthusiasts.", 5)
            },
            [5] = new List<(string, int)>
            {
                ("The yoga mat is incredible! Non-slip and eco-friendly. My practice has improved significantly.", 5),
                ("Their wellness products create such a calming atmosphere at home. The diffuser is a must-have.", 4),
                ("Good quality products but the scent options are limited. Would love to see more variety.", 3)
            },
            [6] = new List<(string, int)>
            {
                ("The fitness tracker is accurate and durable. Battery life exceeds expectations.", 5),
                ("Smart dumbbells are innovative but the app connectivity can be glitchy sometimes.", 3),
                ("Great fitness equipment for home workouts. The chest strap provides accurate heart rate data.", 4)
            },
            [7] = new List<(string, int)>
            {
                ("Love their eco-friendly approach! The air filter has improved our home air quality noticeably.", 5),
                ("Sustainable products that actually work. The bamboo lamp is both functional and beautiful.", 4),
                ("Good concept but some products feel overpriced for what they offer.", 3)
            },
            [8] = new List<(string, int)>
            {
                ("Their tech accessories are top-notch! The charger is fast and reliable for all my devices.", 5),
                ("Great mouse design but the battery life could be better. Comfortable for long work sessions.", 4),
                ("The earbuds have clear sound quality. Perfect for both calls and music.", 4)
            },
            [9] = new List<(string, int)>
            {
                ("My skin has never been happier! The cleanser is gentle yet effective. Love the ethical approach.", 5),
                ("Good skincare line but the moisturizer could be more hydrating for dry skin types.", 3),
                ("The night cream works wonders! Woke up with glowing skin after just one use.", 5)
            },
            [10] = new List<(string, int)>
            {
                ("Fashion-forward pieces that always get compliments! The dress quality is exceptional.", 5),
                ("Trendy designs but some items sell out too quickly. Wish they had better stock management.", 4),
                ("Love their unique style! The handbag is my new favorite accessory for every occasion.", 5)
            }
        };

        var engagementData = new List<(int Likes, int Dislikes)>
        {
            (25, 1), (12, 2), (18, 0),
            (32, 0), (8, 3), (15, 1),
            (28, 0), (10, 1), (3, 5),
            (35, 1), (14, 2), (22, 0),
            (30, 0), (12, 1), (6, 2),
            (27, 0), (5, 4), (11, 1),
            (29, 0), (16, 1), (7, 3),
            (31, 1), (13, 2), (17, 0),
            (26, 0), (4, 2), (24, 1),
            (33, 0), (11, 1), (19, 0)
        };

        for (int brandId = 1; brandId <= 10; brandId++)
        {
            var brandComments = reviewComments[brandId];
            var userIndex = (brandId - 1) * 3;

            for (int i = 0; i < brandComments.Count; i++)
            {
                var (comment, rating) = brandComments[i];
                var userId = userIds[(userIndex + i) % userIds.Count];
                var engagementIndex = (brandId - 1) * 3 + i;
                var (likes, dislikes) = engagementData[engagementIndex];

                reviews.Add(new BrandReview
                {
                    Id = reviewId++,
                    Rating = rating,
                    Comment = comment,
                    CreatedAt = _staticSeedDate.AddDays(brandId * 3 + i),
                    UserId = userId,
                    BrandId = brandId,
                    NumOfLikes = likes,
                    NumOfDislikes = dislikes
                });
            }
        }

        builder.HasData(reviews);
    }
}