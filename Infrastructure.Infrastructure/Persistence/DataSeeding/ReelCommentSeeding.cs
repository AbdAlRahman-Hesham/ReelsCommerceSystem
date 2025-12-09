using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding
{
    public class ReelCommentSeeding : IEntityTypeConfiguration<ReelComment>
    {
        private static readonly DateTime _seedDate =
        new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public void Configure(EntityTypeBuilder<ReelComment> builder)
        {
            builder.HasData([
                new()
            {
                 Id = 1,
                Content = "This product looks amazing! 🔥🔥",
                ReelId = 1,
                UserId = "user1",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 2,
                Content = "I love this brand! 😍",
                ReelId = 1,
                UserId = "user2",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            { 
                Id = 3,
                Content = "Where can I buy this?",
                ReelId = 2,
                UserId = "user3",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 4,
                Content = "Great quality! Highly recommended 💯",
                ReelId = 20,
                UserId = "user6",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 5,
                Content = "Looks nice but is it available in Egypt?",
                ReelId = 8,
                UserId = "user8",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            }
            ]);
        }
    }
}
