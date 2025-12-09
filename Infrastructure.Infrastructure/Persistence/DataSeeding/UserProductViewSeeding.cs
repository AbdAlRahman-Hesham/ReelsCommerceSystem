using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class UserProductViewSeeding : IEntityTypeConfiguration<UserProductView>
{
    public void Configure(EntityTypeBuilder<UserProductView> builder)
    {
        DateTime baseDate = new DateTime(2025, 12, 9, 12, 0, 0, DateTimeKind.Utc);

        builder.HasData(
            new UserProductView { Id = 1, UserId = "user1", ProductId = 1, CreatedAt = baseDate.AddMinutes(1), UpdatedAt = baseDate.AddMinutes(1) },
            new UserProductView { Id = 2, UserId = "user1", ProductId = 2, CreatedAt = baseDate.AddMinutes(2), UpdatedAt = baseDate.AddMinutes(2) },
            new UserProductView { Id = 3, UserId = "user1", ProductId = 3, CreatedAt = baseDate.AddMinutes(3), UpdatedAt = baseDate.AddMinutes(3) },
            new UserProductView { Id = 4, UserId = "user2", ProductId = 2, CreatedAt = baseDate.AddMinutes(4), UpdatedAt = baseDate.AddMinutes(4) },
            new UserProductView { Id = 5, UserId = "user2", ProductId = 4, CreatedAt = baseDate.AddMinutes(5), UpdatedAt = baseDate.AddMinutes(5) },
            new UserProductView { Id = 6, UserId = "user2", ProductId = 5, CreatedAt = baseDate.AddMinutes(6), UpdatedAt = baseDate.AddMinutes(6) },
            new UserProductView { Id = 7, UserId = "user3", ProductId = 1, CreatedAt = baseDate.AddMinutes(7), UpdatedAt = baseDate.AddMinutes(7) },
            new UserProductView { Id = 8, UserId = "user3", ProductId = 6, CreatedAt = baseDate.AddMinutes(8), UpdatedAt = baseDate.AddMinutes(8) },
            new UserProductView { Id = 9, UserId = "user3", ProductId = 3, CreatedAt = baseDate.AddMinutes(9), UpdatedAt = baseDate.AddMinutes(9) },
            new UserProductView { Id = 10, UserId = "user4", ProductId = 2, CreatedAt = baseDate.AddMinutes(10), UpdatedAt = baseDate.AddMinutes(10) },
            new UserProductView { Id = 11, UserId = "user4", ProductId = 5, CreatedAt = baseDate.AddMinutes(11), UpdatedAt = baseDate.AddMinutes(11) }
        );
    }
}