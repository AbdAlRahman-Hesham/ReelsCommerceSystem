using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding
{
    public class ReelLikeSeeding : IEntityTypeConfiguration<UserReelLike>
    {
        public void Configure(EntityTypeBuilder<UserReelLike> builder)
        {
            builder.HasData([
                new { Id = 1,  CreatedAt = new DateTime(2025, 01, 02, 10, 12, 44, DateTimeKind.Utc), ReelId = 13, UpdatedAt = new DateTime(2025, 01, 02, 10, 12, 49, DateTimeKind.Utc), UserId = "user3" },
                new { Id = 3,  CreatedAt = new DateTime(2025, 01, 06, 09, 11, 18, DateTimeKind.Utc), ReelId = 5,  UpdatedAt = new DateTime(2025, 01, 06, 09, 11, 24, DateTimeKind.Utc), UserId = "user1" },
                new { Id = 4,  CreatedAt = new DateTime(2025, 01, 07, 16, 44, 39, DateTimeKind.Utc), ReelId = 32, UpdatedAt = new DateTime(2025, 01, 07, 16, 44, 45, DateTimeKind.Utc), UserId = "user9" },
                new { Id = 2,  CreatedAt = new DateTime(2025, 01, 04, 14, 55, 20, DateTimeKind.Utc), ReelId = 27, UpdatedAt = new DateTime(2025, 01, 04, 14, 55, 25, DateTimeKind.Utc), UserId = "user7" },
                new { Id = 5,  CreatedAt = new DateTime(2025, 01, 08, 07, 32, 51, DateTimeKind.Utc), ReelId = 48, UpdatedAt = new DateTime(2025, 01, 08, 07, 32, 57, DateTimeKind.Utc), UserId = "user4" },
                new { Id = 6,  CreatedAt = new DateTime(2025, 01, 09, 11, 10, 12, DateTimeKind.Utc), ReelId = 2,  UpdatedAt = new DateTime(2025, 01, 09, 11, 10, 17, DateTimeKind.Utc), UserId = "user6" },
                new { Id = 7,  CreatedAt = new DateTime(2025, 01, 10, 19, 27, 33, DateTimeKind.Utc), ReelId = 14, UpdatedAt = new DateTime(2025, 01, 10, 19, 27, 41, DateTimeKind.Utc), UserId = "user2" },
                new { Id = 8,  CreatedAt = new DateTime(2025, 01, 12, 06, 55, 21, DateTimeKind.Utc), ReelId = 45, UpdatedAt = new DateTime(2025, 01, 12, 06, 55, 28, DateTimeKind.Utc), UserId = "user8" },
                new { Id = 9,  CreatedAt = new DateTime(2025, 01, 13, 17, 13, 09, DateTimeKind.Utc), ReelId = 7,  UpdatedAt = new DateTime(2025, 01, 13, 17, 13, 14, DateTimeKind.Utc), UserId = "user5" },
                new { Id = 10, CreatedAt = new DateTime(2025, 01, 15, 12, 41, 55, DateTimeKind.Utc), ReelId = 22, UpdatedAt = new DateTime(2025, 01, 15, 12, 42, 02, DateTimeKind.Utc), UserId = "user10" },

                new { Id = 11, CreatedAt = new DateTime(2025, 01, 16, 08, 11, 17, DateTimeKind.Utc), ReelId = 49, UpdatedAt = new DateTime(2025, 01, 16, 08, 11, 23, DateTimeKind.Utc), UserId = "user3" },
                new { Id = 12, CreatedAt = new DateTime(2025, 01, 17, 20, 22, 43, DateTimeKind.Utc), ReelId = 36, UpdatedAt = new DateTime(2025, 01, 17, 20, 22, 49, DateTimeKind.Utc), UserId = "user7" },
                new { Id = 13, CreatedAt = new DateTime(2025, 01, 18, 09, 59, 50, DateTimeKind.Utc), ReelId = 1,  UpdatedAt = new DateTime(2025, 01, 18, 09, 59, 55, DateTimeKind.Utc), UserId = "user6" },
                new { Id = 14, CreatedAt = new DateTime(2025, 01, 19, 15, 33, 14, DateTimeKind.Utc), ReelId = 28, UpdatedAt = new DateTime(2025, 01, 19, 15, 33, 19, DateTimeKind.Utc), UserId = "user9" },
                new { Id = 15, CreatedAt = new DateTime(2025, 01, 20, 11, 24, 31, DateTimeKind.Utc), ReelId = 40, UpdatedAt = new DateTime(2025, 01, 20, 11, 24, 37, DateTimeKind.Utc), UserId = "user2" },
                new { Id = 16, CreatedAt = new DateTime(2025, 01, 21, 18, 18, 47, DateTimeKind.Utc), ReelId = 16, UpdatedAt = new DateTime(2025, 01, 21, 18, 18, 51, DateTimeKind.Utc), UserId = "user1" },
                new { Id = 17, CreatedAt = new DateTime(2025, 01, 22, 07, 25, 58, DateTimeKind.Utc), ReelId = 26, UpdatedAt = new DateTime(2025, 01, 22, 07, 26, 04, DateTimeKind.Utc), UserId = "user5" },
                new { Id = 18, CreatedAt = new DateTime(2025, 01, 23, 10, 14, 13, DateTimeKind.Utc), ReelId = 11, UpdatedAt = new DateTime(2025, 01, 23, 10, 14, 18, DateTimeKind.Utc), UserId = "user8" },
                new { Id = 19, CreatedAt = new DateTime(2025, 01, 24, 16, 52, 22, DateTimeKind.Utc), ReelId = 20, UpdatedAt = new DateTime(2025, 01, 24, 16, 52, 28, DateTimeKind.Utc), UserId = "user10" },
                new { Id = 20, CreatedAt = new DateTime(2025, 01, 25, 12, 08, 43, DateTimeKind.Utc), ReelId = 33, UpdatedAt = new DateTime(2025, 01, 25, 12, 08, 50, DateTimeKind.Utc), UserId = "user4" },

                new { Id = 21, CreatedAt = new DateTime(2025, 01, 26, 09, 57, 12, DateTimeKind.Utc), ReelId = 8,  UpdatedAt = new DateTime(2025, 01, 26, 09, 57, 17, DateTimeKind.Utc), UserId = "user7" },
                new { Id = 22, CreatedAt = new DateTime(2025, 01, 27, 17, 33, 29, DateTimeKind.Utc), ReelId = 31, UpdatedAt = new DateTime(2025, 01, 27, 17, 33, 35, DateTimeKind.Utc), UserId = "user6" },
                new { Id = 23, CreatedAt = new DateTime(2025, 01, 28, 14, 19, 56, DateTimeKind.Utc), ReelId = 19, UpdatedAt = new DateTime(2025, 01, 28, 14, 20, 01, DateTimeKind.Utc), UserId = "user3" },
                new { Id = 24, CreatedAt = new DateTime(2025, 01, 29, 10, 42, 24, DateTimeKind.Utc), ReelId = 25, UpdatedAt = new DateTime(2025, 01, 29, 10, 42, 30, DateTimeKind.Utc), UserId = "user10" },
                new { Id = 25, CreatedAt = new DateTime(2025, 01, 30, 06, 28, 33, DateTimeKind.Utc), ReelId = 43, UpdatedAt = new DateTime(2025, 01, 30, 06, 28, 39, DateTimeKind.Utc), UserId = "user2" },
                new { Id = 26, CreatedAt = new DateTime(2025, 01, 31, 20, 51, 45, DateTimeKind.Utc), ReelId = 9,  UpdatedAt = new DateTime(2025, 01, 31, 20, 51, 51, DateTimeKind.Utc), UserId = "user8" },
                new { Id = 27, CreatedAt = new DateTime(2025, 02, 01, 11, 06, 59, DateTimeKind.Utc), ReelId = 34, UpdatedAt = new DateTime(2025, 02, 01, 11, 07, 04, DateTimeKind.Utc), UserId = "user5" },
                new { Id = 28, CreatedAt = new DateTime(2025, 02, 02, 14, 14, 12, DateTimeKind.Utc), ReelId = 18, UpdatedAt = new DateTime(2025, 02, 02, 14, 14, 16, DateTimeKind.Utc), UserId = "user9" },
                new { Id = 29, CreatedAt = new DateTime(2025, 02, 03, 09, 25, 41, DateTimeKind.Utc), ReelId = 4,  UpdatedAt = new DateTime(2025, 02, 03, 09, 25, 46, DateTimeKind.Utc), UserId = "user4" },
                new { Id = 30, CreatedAt = new DateTime(2025, 02, 04, 15, 33, 27, DateTimeKind.Utc), ReelId = 41, UpdatedAt = new DateTime(2025, 02, 04, 15, 33, 33, DateTimeKind.Utc), UserId = "user1" },

                new { Id = 31, CreatedAt = new DateTime(2025, 02, 05, 13, 44, 55, DateTimeKind.Utc), ReelId = 12, UpdatedAt = new DateTime(2025, 02, 05, 13, 45, 02, DateTimeKind.Utc), UserId = "user6" },
                new { Id = 32, CreatedAt = new DateTime(2025, 02, 06, 07, 29, 42, DateTimeKind.Utc), ReelId = 30, UpdatedAt = new DateTime(2025, 02, 06, 07, 29, 49, DateTimeKind.Utc), UserId = "user7" },
                new { Id = 33, CreatedAt = new DateTime(2025, 02, 07, 18, 21, 34, DateTimeKind.Utc), ReelId = 3,  UpdatedAt = new DateTime(2025, 02, 07, 18, 21, 40, DateTimeKind.Utc), UserId = "user10" },
                new { Id = 34, CreatedAt = new DateTime(2025, 02, 08, 10, 19, 09, DateTimeKind.Utc), ReelId = 35, UpdatedAt = new DateTime(2025, 02, 08, 10, 19, 14, DateTimeKind.Utc), UserId = "user8" },
                new { Id = 35, CreatedAt = new DateTime(2025, 02, 09, 20, 58, 11, DateTimeKind.Utc), ReelId = 21, UpdatedAt = new DateTime(2025, 02, 09, 20, 58, 18, DateTimeKind.Utc), UserId = "user3" },
                new { Id = 36, CreatedAt = new DateTime(2025, 02, 10, 08, 41, 33, DateTimeKind.Utc), ReelId = 17, UpdatedAt = new DateTime(2025, 02, 10, 08, 41, 38, DateTimeKind.Utc), UserId = "user2" },
                new { Id = 37, CreatedAt = new DateTime(2025, 02, 11, 14, 30, 09, DateTimeKind.Utc), ReelId = 38, UpdatedAt = new DateTime(2025, 02, 11, 14, 30, 15, DateTimeKind.Utc), UserId = "user5" },
                new { Id = 38, CreatedAt = new DateTime(2025, 02, 12, 09, 55, 58, DateTimeKind.Utc), ReelId = 42, UpdatedAt = new DateTime(2025, 02, 12, 09, 56, 04, DateTimeKind.Utc), UserId = "user4" },
                new { Id = 39, CreatedAt = new DateTime(2025, 02, 13, 16, 12, 23, DateTimeKind.Utc), ReelId = 6,  UpdatedAt = new DateTime(2025, 02, 13, 16, 12, 29, DateTimeKind.Utc), UserId = "user9" },
                new { Id = 40, CreatedAt = new DateTime(2025, 02, 14, 19, 25, 18, DateTimeKind.Utc), ReelId = 23, UpdatedAt = new DateTime(2025, 02, 14, 19, 25, 22, DateTimeKind.Utc), UserId = "user1" },

                new { Id = 41, CreatedAt = new DateTime(2025, 02, 15, 11, 48, 47, DateTimeKind.Utc), ReelId = 47, UpdatedAt = new DateTime(2025, 02, 15, 11, 48, 53, DateTimeKind.Utc), UserId = "user7" },
                new { Id = 42, CreatedAt = new DateTime(2025, 02, 16, 15, 52, 14, DateTimeKind.Utc), ReelId = 24, UpdatedAt = new DateTime(2025, 02, 16, 15, 52, 20, DateTimeKind.Utc), UserId = "user8" },
                new { Id = 43, CreatedAt = new DateTime(2025, 02, 17, 07, 39, 33, DateTimeKind.Utc), ReelId = 10, UpdatedAt = new DateTime(2025, 02, 17, 07, 39, 38, DateTimeKind.Utc), UserId = "user4" },
                new { Id = 44, CreatedAt = new DateTime(2025, 02, 18, 17, 10, 41, DateTimeKind.Utc), ReelId = 29, UpdatedAt = new DateTime(2025, 02, 18, 17, 10, 47, DateTimeKind.Utc), UserId = "user6" },
                new { Id = 45, CreatedAt = new DateTime(2025, 02, 19, 12, 28, 55, DateTimeKind.Utc), ReelId = 15, UpdatedAt = new DateTime(2025, 02, 19, 12, 29, 01, DateTimeKind.Utc), UserId = "user5" },
                new { Id = 46, CreatedAt = new DateTime(2025, 02, 20, 14, 55, 11, DateTimeKind.Utc), ReelId = 44, UpdatedAt = new DateTime(2025, 02, 20, 14, 55, 18, DateTimeKind.Utc), UserId = "user10" },
                new { Id = 47, CreatedAt = new DateTime(2025, 02, 21, 09, 22, 33, DateTimeKind.Utc), ReelId = 37, UpdatedAt = new DateTime(2025, 02, 21, 09, 22, 39, DateTimeKind.Utc), UserId = "user2" },
                new { Id = 48, CreatedAt = new DateTime(2025, 02, 22, 13, 31, 12, DateTimeKind.Utc), ReelId = 46, UpdatedAt = new DateTime(2025, 02, 22, 13, 31, 18, DateTimeKind.Utc), UserId = "user3" },
                new { Id = 49, CreatedAt = new DateTime(2025, 02, 23, 19, 14, 59, DateTimeKind.Utc), ReelId = 50, UpdatedAt = new DateTime(2025, 02, 23, 19, 15, 05, DateTimeKind.Utc), UserId = "user9" },
                new { Id = 50, CreatedAt = new DateTime(2025, 02, 24, 08, 42, 54, DateTimeKind.Utc), ReelId = 39, UpdatedAt = new DateTime(2025, 02, 24, 08, 43, 00, DateTimeKind.Utc), UserId = "user1" },

                new { Id = 51, CreatedAt = new DateTime(2025, 02, 25, 10, 55, 21, DateTimeKind.Utc), ReelId = 3,  UpdatedAt = new DateTime(2025, 02, 25, 10, 55, 27, DateTimeKind.Utc), UserId = "user6" },
                new { Id = 52, CreatedAt = new DateTime(2025, 02, 26, 18, 27, 11, DateTimeKind.Utc), ReelId = 12, UpdatedAt = new DateTime(2025, 02, 26, 18, 27, 17, DateTimeKind.Utc), UserId = "user2" },
                new { Id = 53, CreatedAt = new DateTime(2025, 02, 27, 07, 17, 45, DateTimeKind.Utc), ReelId = 5,  UpdatedAt = new DateTime(2025, 02, 27, 07, 17, 50, DateTimeKind.Utc), UserId = "user7" },
                new { Id = 54, CreatedAt = new DateTime(2025, 02, 28, 13, 31, 59, DateTimeKind.Utc), ReelId = 18, UpdatedAt = new DateTime(2025, 02, 28, 13, 32, 05, DateTimeKind.Utc), UserId = "user4" },
                new { Id = 55, CreatedAt = new DateTime(2025, 03, 01, 16, 40, 28, DateTimeKind.Utc), ReelId = 41, UpdatedAt = new DateTime(2025, 03, 01, 16, 40, 34, DateTimeKind.Utc), UserId = "user5" },
                new { Id = 56, CreatedAt = new DateTime(2025, 03, 02, 09, 23, 44, DateTimeKind.Utc), ReelId = 7,  UpdatedAt = new DateTime(2025, 03, 02, 09, 23, 50, DateTimeKind.Utc), UserId = "user10" },
                new { Id = 57, CreatedAt = new DateTime(2025, 03, 03, 14, 14, 58, DateTimeKind.Utc), ReelId = 26, UpdatedAt = new DateTime(2025, 03, 03, 14, 15, 03, DateTimeKind.Utc), UserId = "user8" },
                new { Id = 58, CreatedAt = new DateTime(2025, 03, 04, 18, 33, 18, DateTimeKind.Utc), ReelId = 9,  UpdatedAt = new DateTime(2025, 03, 04, 18, 33, 24, DateTimeKind.Utc), UserId = "user3" },
                new { Id = 59, CreatedAt = new DateTime(2025, 03, 05, 08, 56, 29, DateTimeKind.Utc), ReelId = 22, UpdatedAt = new DateTime(2025, 03, 05, 08, 56, 35, DateTimeKind.Utc), UserId = "user4" },
                new { Id = 60, CreatedAt = new DateTime(2025, 03, 06, 12, 51, 28, DateTimeKind.Utc), ReelId = 9,  UpdatedAt = new DateTime(2025, 03, 06, 12, 51, 34, DateTimeKind.Utc), UserId = "user2" },

                ]);
        }
    }
}
