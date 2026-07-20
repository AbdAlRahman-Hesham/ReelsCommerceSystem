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
    public class ReelViewSeeding : IEntityTypeConfiguration<UserReelView>
    {
        public void Configure(EntityTypeBuilder<UserReelView> builder)
        {
            builder.HasData([
                new { Id = 1,  CreatedAt = new DateTime(2025, 01, 03, 09, 14, 22, DateTimeKind.Utc), ReelId = 12, UpdatedAt = new DateTime(2025, 01, 03, 09, 14, 31, DateTimeKind.Utc), UserId = "user4", WatchedDurationSeconds = 44, VideoDurationSeconds = 80 },
                new { Id = 2,  CreatedAt = new DateTime(2025, 01, 05, 11, 22, 10, DateTimeKind.Utc), ReelId = 7,  UpdatedAt = new DateTime(2025, 01, 05, 11, 22, 15, DateTimeKind.Utc), UserId = "user1", WatchedDurationSeconds = 61, VideoDurationSeconds = 120 },
                new { Id = 3,  CreatedAt = new DateTime(2025, 01, 08, 14, 45, 51, DateTimeKind.Utc), ReelId = 25, UpdatedAt = new DateTime(2025, 01, 08, 14, 45, 56, DateTimeKind.Utc), UserId = "user9", WatchedDurationSeconds = 20, VideoDurationSeconds = 55 },
                new { Id = 4,  CreatedAt = new DateTime(2025, 01, 11, 16, 20, 12, DateTimeKind.Utc), ReelId = 3,  UpdatedAt = new DateTime(2025, 01, 11, 16, 20, 19, DateTimeKind.Utc), UserId = "user3", WatchedDurationSeconds = 78, VideoDurationSeconds = 130 },
                new { Id = 5,  CreatedAt = new DateTime(2025, 01, 13, 18, 02, 44, DateTimeKind.Utc), ReelId = 31, UpdatedAt = new DateTime(2025, 01, 13, 18, 02, 47, DateTimeKind.Utc), UserId = "user8", WatchedDurationSeconds = 16, VideoDurationSeconds = 70 },
                new { Id = 6,  CreatedAt = new DateTime(2025, 01, 14, 07, 18, 33, DateTimeKind.Utc), ReelId = 19, UpdatedAt = new DateTime(2025, 01, 14, 07, 18, 40, DateTimeKind.Utc), UserId = "user7", WatchedDurationSeconds = 93, VideoDurationSeconds = 150 },
                new { Id = 7,  CreatedAt = new DateTime(2025, 01, 15, 09, 59, 28, DateTimeKind.Utc), ReelId = 8,  UpdatedAt = new DateTime(2025, 01, 15, 09, 59, 33, DateTimeKind.Utc), UserId = "user2", WatchedDurationSeconds = 27, VideoDurationSeconds = 44 },
                new { Id = 8,  CreatedAt = new DateTime(2025, 01, 17, 11, 44, 51, DateTimeKind.Utc), ReelId = 44, UpdatedAt = new DateTime(2025, 01, 17, 11, 44, 57, DateTimeKind.Utc), UserId = "user6", WatchedDurationSeconds = 36, VideoDurationSeconds = 90 },
                new { Id = 9,  CreatedAt = new DateTime(2025, 01, 18, 13, 26, 11, DateTimeKind.Utc), ReelId = 15, UpdatedAt = new DateTime(2025, 01, 18, 13, 26, 18, DateTimeKind.Utc), UserId = "user5", WatchedDurationSeconds = 55, VideoDurationSeconds = 100 },
                new { Id = 10, CreatedAt = new DateTime(2025, 01, 20, 15, 10, 05, DateTimeKind.Utc), ReelId = 50, UpdatedAt = new DateTime(2025, 01, 20, 15, 10, 08, DateTimeKind.Utc), UserId = "user10", WatchedDurationSeconds = 88, VideoDurationSeconds = 140 },

                new { Id = 11, CreatedAt = new DateTime(2025, 01, 22, 09, 41, 39, DateTimeKind.Utc), ReelId = 18, UpdatedAt = new DateTime(2025, 01, 22, 09, 41, 44, DateTimeKind.Utc), UserId = "user3", WatchedDurationSeconds = 41, VideoDurationSeconds = 90 },
                new { Id = 12, CreatedAt = new DateTime(2025, 01, 23, 12, 27, 17, DateTimeKind.Utc), ReelId = 4,  UpdatedAt = new DateTime(2025, 01, 23, 12, 27, 19, DateTimeKind.Utc), UserId = "user2", WatchedDurationSeconds = 66, VideoDurationSeconds = 110 },
                new { Id = 13, CreatedAt = new DateTime(2025, 01, 24, 14, 55, 09, DateTimeKind.Utc), ReelId = 36, UpdatedAt = new DateTime(2025, 01, 24, 14, 55, 16, DateTimeKind.Utc), UserId = "user4", WatchedDurationSeconds = 22, VideoDurationSeconds = 60 },
                new { Id = 14, CreatedAt = new DateTime(2025, 01, 25, 16, 33, 44, DateTimeKind.Utc), ReelId = 10, UpdatedAt = new DateTime(2025, 01, 25, 16, 33, 50, DateTimeKind.Utc), UserId = "user7", WatchedDurationSeconds = 80, VideoDurationSeconds = 120 },
                new { Id = 15, CreatedAt = new DateTime(2025, 01, 27, 18, 14, 29, DateTimeKind.Utc), ReelId = 27, UpdatedAt = new DateTime(2025, 01, 27, 18, 14, 32, DateTimeKind.Utc), UserId = "user1", WatchedDurationSeconds = 13, VideoDurationSeconds = 40 },
                new { Id = 16, CreatedAt = new DateTime(2025, 01, 28, 07, 21, 58, DateTimeKind.Utc), ReelId = 5,  UpdatedAt = new DateTime(2025, 01, 28, 07, 22, 04, DateTimeKind.Utc), UserId = "user6", WatchedDurationSeconds = 34, VideoDurationSeconds = 77 },
                new { Id = 17, CreatedAt = new DateTime(2025, 01, 29, 10, 49, 41, DateTimeKind.Utc), ReelId = 48, UpdatedAt = new DateTime(2025, 01, 29, 10, 49, 45, DateTimeKind.Utc), UserId = "user9", WatchedDurationSeconds = 59, VideoDurationSeconds = 117 },
                new { Id = 18, CreatedAt = new DateTime(2025, 01, 30, 11, 56, 12, DateTimeKind.Utc), ReelId = 23, UpdatedAt = new DateTime(2025, 01, 30, 11, 56, 19, DateTimeKind.Utc), UserId = "user10", WatchedDurationSeconds = 71, VideoDurationSeconds = 130 },
                new { Id = 19, CreatedAt = new DateTime(2025, 02, 01, 08, 15, 55, DateTimeKind.Utc), ReelId = 1,  UpdatedAt = new DateTime(2025, 02, 01, 08, 16, 01, DateTimeKind.Utc), UserId = "user8", WatchedDurationSeconds = 26, VideoDurationSeconds = 80 },
                new { Id = 20, CreatedAt = new DateTime(2025, 02, 02, 09, 37, 26, DateTimeKind.Utc), ReelId = 22, UpdatedAt = new DateTime(2025, 02, 02, 09, 37, 32, DateTimeKind.Utc), UserId = "user5", WatchedDurationSeconds = 52, VideoDurationSeconds = 104 },

                new { Id = 21, CreatedAt = new DateTime(2025, 02, 03, 12, 58, 51, DateTimeKind.Utc), ReelId = 17, UpdatedAt = new DateTime(2025, 02, 03, 12, 58, 55, DateTimeKind.Utc), UserId = "user1", WatchedDurationSeconds = 47, VideoDurationSeconds = 90 },
                new { Id = 22, CreatedAt = new DateTime(2025, 02, 04, 15, 19, 33, DateTimeKind.Utc), ReelId = 29, UpdatedAt = new DateTime(2025, 02, 04, 15, 19, 37, DateTimeKind.Utc), UserId = "user3", WatchedDurationSeconds = 32, VideoDurationSeconds = 95 },
                new { Id = 23, CreatedAt = new DateTime(2025, 02, 05, 17, 40, 28, DateTimeKind.Utc), ReelId = 49, UpdatedAt = new DateTime(2025, 02, 05, 17, 40, 33, DateTimeKind.Utc), UserId = "user5", WatchedDurationSeconds = 89, VideoDurationSeconds = 150 },
                new { Id = 24, CreatedAt = new DateTime(2025, 02, 06, 09, 22, 14, DateTimeKind.Utc), ReelId = 11, UpdatedAt = new DateTime(2025, 02, 06, 09, 22, 20, DateTimeKind.Utc), UserId = "user10", WatchedDurationSeconds = 18, VideoDurationSeconds = 70 },
                new { Id = 25, CreatedAt = new DateTime(2025, 02, 07, 11, 34, 59, DateTimeKind.Utc), ReelId = 32, UpdatedAt = new DateTime(2025, 02, 07, 11, 35, 06, DateTimeKind.Utc), UserId = "user4", WatchedDurationSeconds = 70, VideoDurationSeconds = 130 },
                new { Id = 26, CreatedAt = new DateTime(2025, 02, 08, 13, 46, 42, DateTimeKind.Utc), ReelId = 45, UpdatedAt = new DateTime(2025, 02, 08, 13, 46, 49, DateTimeKind.Utc), UserId = "user6", WatchedDurationSeconds = 29, VideoDurationSeconds = 75 },
                new { Id = 27, CreatedAt = new DateTime(2025, 02, 09, 15, 58, 30, DateTimeKind.Utc), ReelId = 9,  UpdatedAt = new DateTime(2025, 02, 09, 15, 58, 37, DateTimeKind.Utc), UserId = "user7", WatchedDurationSeconds = 55, VideoDurationSeconds = 110 },
                new { Id = 28, CreatedAt = new DateTime(2025, 02, 10, 18, 10, 25, DateTimeKind.Utc), ReelId = 6,  UpdatedAt = new DateTime(2025, 02, 10, 18, 10, 30, DateTimeKind.Utc), UserId = "user2", WatchedDurationSeconds = 24, VideoDurationSeconds = 60 },
                new { Id = 29, CreatedAt = new DateTime(2025, 02, 11, 08, 21, 44, DateTimeKind.Utc), ReelId = 40, UpdatedAt = new DateTime(2025, 02, 11, 08, 21, 50, DateTimeKind.Utc), UserId = "user8", WatchedDurationSeconds = 39, VideoDurationSeconds = 100 },
                new { Id = 30, CreatedAt = new DateTime(2025, 02, 12, 10, 33, 19, DateTimeKind.Utc), ReelId = 28, UpdatedAt = new DateTime(2025, 02, 12, 10, 33, 26, DateTimeKind.Utc), UserId = "user9", WatchedDurationSeconds = 91, VideoDurationSeconds = 140 },

                new { Id = 31, CreatedAt = new DateTime(2025, 02, 13, 12, 44, 55, DateTimeKind.Utc), ReelId = 16, UpdatedAt = new DateTime(2025, 02, 13, 12, 45, 01, DateTimeKind.Utc), UserId = "user3", WatchedDurationSeconds = 30, VideoDurationSeconds = 66 },
                new { Id = 32, CreatedAt = new DateTime(2025, 02, 14, 14, 56, 37, DateTimeKind.Utc), ReelId = 34, UpdatedAt = new DateTime(2025, 02, 14, 14, 56, 43, DateTimeKind.Utc), UserId = "user2", WatchedDurationSeconds = 57, VideoDurationSeconds = 120 },
                new { Id = 33, CreatedAt = new DateTime(2025, 02, 15, 09, 11, 23, DateTimeKind.Utc), ReelId = 14, UpdatedAt = new DateTime(2025, 02, 15, 09, 11, 28, DateTimeKind.Utc), UserId = "user1", WatchedDurationSeconds = 11, VideoDurationSeconds = 40 },
                new { Id = 34, CreatedAt = new DateTime(2025, 02, 16, 11, 23, 46, DateTimeKind.Utc), ReelId = 39, UpdatedAt = new DateTime(2025, 02, 16, 11, 23, 52, DateTimeKind.Utc), UserId = "user6", WatchedDurationSeconds = 68, VideoDurationSeconds = 130 },
                new { Id = 35, CreatedAt = new DateTime(2025, 02, 17, 13, 35, 09, DateTimeKind.Utc), ReelId = 20, UpdatedAt = new DateTime(2025, 02, 17, 13, 35, 14, DateTimeKind.Utc), UserId = "user4", WatchedDurationSeconds = 17, VideoDurationSeconds = 70 },
                new { Id = 36, CreatedAt = new DateTime(2025, 02, 18, 16, 47, 50, DateTimeKind.Utc), ReelId = 2,  UpdatedAt = new DateTime(2025, 02, 18, 16, 47, 56, DateTimeKind.Utc), UserId = "user9", WatchedDurationSeconds = 33, VideoDurationSeconds = 90 },
                new { Id = 37, CreatedAt = new DateTime(2025, 02, 19, 18, 59, 33, DateTimeKind.Utc), ReelId = 21, UpdatedAt = new DateTime(2025, 02, 19, 18, 59, 38, DateTimeKind.Utc), UserId = "user4", WatchedDurationSeconds = 77, VideoDurationSeconds = 135 },
                new { Id = 38, CreatedAt = new DateTime(2025, 02, 20, 08, 14, 11, DateTimeKind.Utc), ReelId = 47, UpdatedAt = new DateTime(2025, 02, 20, 08, 14, 18, DateTimeKind.Utc), UserId = "user10", WatchedDurationSeconds = 26, VideoDurationSeconds = 90 },
                new { Id = 39, CreatedAt = new DateTime(2025, 02, 21, 10, 26, 44, DateTimeKind.Utc), ReelId = 30, UpdatedAt = new DateTime(2025, 02, 21, 10, 26, 48, DateTimeKind.Utc), UserId = "user7", WatchedDurationSeconds = 45, VideoDurationSeconds = 100 },
                new { Id = 40, CreatedAt = new DateTime(2025, 02, 22, 12, 38, 52, DateTimeKind.Utc), ReelId = 35, UpdatedAt = new DateTime(2025, 02, 22, 12, 38, 59, DateTimeKind.Utc), UserId = "user5", WatchedDurationSeconds = 86, VideoDurationSeconds = 150 },

                new { Id = 41, CreatedAt = new DateTime(2025, 02, 23, 14, 50, 41, DateTimeKind.Utc), ReelId = 26, UpdatedAt = new DateTime(2025, 02, 23, 14, 50, 47, DateTimeKind.Utc), UserId = "user3", WatchedDurationSeconds = 28, VideoDurationSeconds = 75 },
                new { Id = 42, CreatedAt = new DateTime(2025, 02, 24, 09, 01, 33, DateTimeKind.Utc), ReelId = 38, UpdatedAt = new DateTime(2025, 02, 24, 09, 01, 37, DateTimeKind.Utc), UserId = "user8", WatchedDurationSeconds = 53, VideoDurationSeconds = 90 },
                new { Id = 43, CreatedAt = new DateTime(2025, 02, 25, 11, 13, 20, DateTimeKind.Utc), ReelId = 46, UpdatedAt = new DateTime(2025, 02, 25, 11, 13, 26, DateTimeKind.Utc), UserId = "user2", WatchedDurationSeconds = 71, VideoDurationSeconds = 140 },
                new { Id = 44, CreatedAt = new DateTime(2025, 02, 26, 13, 25, 12, DateTimeKind.Utc), ReelId = 41, UpdatedAt = new DateTime(2025, 02, 26, 13, 25, 16, DateTimeKind.Utc), UserId = "user6", WatchedDurationSeconds = 25, VideoDurationSeconds = 70 },
                new { Id = 45, CreatedAt = new DateTime(2025, 02, 27, 15, 37, 05, DateTimeKind.Utc), ReelId = 24, UpdatedAt = new DateTime(2025, 02, 27, 15, 37, 09, DateTimeKind.Utc), UserId = "user1", WatchedDurationSeconds = 49, VideoDurationSeconds = 95 },
                new { Id = 46, CreatedAt = new DateTime(2025, 02, 28, 17, 49, 52, DateTimeKind.Utc), ReelId = 43, UpdatedAt = new DateTime(2025, 02, 28, 17, 49, 58, DateTimeKind.Utc), UserId = "user7", WatchedDurationSeconds = 84, VideoDurationSeconds = 145 },
                new { Id = 47, CreatedAt = new DateTime(2025, 03, 01, 08, 04, 18, DateTimeKind.Utc), ReelId = 33, UpdatedAt = new DateTime(2025, 03, 01, 08, 04, 24, DateTimeKind.Utc), UserId = "user9", WatchedDurationSeconds = 15, VideoDurationSeconds = 50 },
                new { Id = 48, CreatedAt = new DateTime(2025, 03, 02, 10, 16, 47, DateTimeKind.Utc), ReelId = 42, UpdatedAt = new DateTime(2025, 03, 02, 10, 16, 52, DateTimeKind.Utc), UserId = "user10", WatchedDurationSeconds = 67, VideoDurationSeconds = 120 },
                new { Id = 49, CreatedAt = new DateTime(2025, 03, 03, 12, 28, 39, DateTimeKind.Utc), ReelId = 37, UpdatedAt = new DateTime(2025, 03, 03, 12, 28, 45, DateTimeKind.Utc), UserId = "user4", WatchedDurationSeconds = 21, VideoDurationSeconds = 60 },
                new { Id = 50, CreatedAt = new DateTime(2025, 03, 04, 14, 40, 22, DateTimeKind.Utc), ReelId = 13, UpdatedAt = new DateTime(2025, 03, 04, 14, 40, 27, DateTimeKind.Utc), UserId = "user5", WatchedDurationSeconds = 72, VideoDurationSeconds = 130 },

                new { Id = 51, CreatedAt = new DateTime(2025, 03, 05, 16, 52, 11, DateTimeKind.Utc), ReelId = 6,  UpdatedAt = new DateTime(2025, 03, 05, 16, 52, 14, DateTimeKind.Utc), UserId = "user7", WatchedDurationSeconds = 39, VideoDurationSeconds = 90 },
                new { Id = 52, CreatedAt = new DateTime(2025, 03, 06, 09, 03, 44, DateTimeKind.Utc), ReelId = 4,  UpdatedAt = new DateTime(2025, 03, 06, 09, 03, 49, DateTimeKind.Utc), UserId = "user6", WatchedDurationSeconds = 91, VideoDurationSeconds = 140 },
                new { Id = 53, CreatedAt = new DateTime(2025, 03, 07, 11, 15, 26, DateTimeKind.Utc), ReelId = 7,  UpdatedAt = new DateTime(2025, 03, 07, 11, 15, 32, DateTimeKind.Utc), UserId = "user1", WatchedDurationSeconds = 48, VideoDurationSeconds = 100 },
                new { Id = 54, CreatedAt = new DateTime(2025, 03, 08, 13, 27, 09, DateTimeKind.Utc), ReelId = 27, UpdatedAt = new DateTime(2025, 03, 08, 13, 27, 14, DateTimeKind.Utc), UserId = "user3", WatchedDurationSeconds = 63, VideoDurationSeconds = 120 },
                new { Id = 55, CreatedAt = new DateTime(2025, 03, 09, 15, 39, 52, DateTimeKind.Utc), ReelId = 12, UpdatedAt = new DateTime(2025, 03, 09, 15, 39, 57, DateTimeKind.Utc), UserId = "user2", WatchedDurationSeconds = 90, VideoDurationSeconds = 160 },
                new { Id = 56, CreatedAt = new DateTime(2025, 03, 10, 17, 51, 44, DateTimeKind.Utc), ReelId = 8,  UpdatedAt = new DateTime(2025, 03, 10, 17, 51, 49, DateTimeKind.Utc), UserId = "user10", WatchedDurationSeconds = 12, VideoDurationSeconds = 50 },
                new { Id = 57, CreatedAt = new DateTime(2025, 03, 11, 08, 02, 33, DateTimeKind.Utc), ReelId = 17, UpdatedAt = new DateTime(2025, 03, 11, 08, 02, 39, DateTimeKind.Utc), UserId = "user8", WatchedDurationSeconds = 22, VideoDurationSeconds = 70 },
                new { Id = 58, CreatedAt = new DateTime(2025, 03, 12, 10, 14, 19, DateTimeKind.Utc), ReelId = 50, UpdatedAt = new DateTime(2025, 03, 12, 10, 14, 26, DateTimeKind.Utc), UserId = "user5", WatchedDurationSeconds = 77, VideoDurationSeconds = 130 },
                new { Id = 59, CreatedAt = new DateTime(2025, 03, 13, 12, 26, 57, DateTimeKind.Utc), ReelId = 19, UpdatedAt = new DateTime(2025, 03, 13, 12, 27, 02, DateTimeKind.Utc), UserId = "user9", WatchedDurationSeconds = 55, VideoDurationSeconds = 90 },
                new { Id = 60, CreatedAt = new DateTime(2025, 03, 14, 14, 38, 30, DateTimeKind.Utc), ReelId = 31, UpdatedAt = new DateTime(2025, 03, 14, 14, 38, 36, DateTimeKind.Utc), UserId = "user4", WatchedDurationSeconds = 35, VideoDurationSeconds = 80 },

                new { Id = 61, CreatedAt = new DateTime(2026, 01, 03, 10, 12, 15, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 01, 03, 10, 12, 20, DateTimeKind.Utc), UserId = "user1", WatchedDurationSeconds = 68, VideoDurationSeconds = 90 },

                new { Id = 62, CreatedAt = new DateTime(2026, 01, 05, 13, 22, 41, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 01, 05, 13, 22, 47, DateTimeKind.Utc), UserId = "user2", WatchedDurationSeconds = 84, VideoDurationSeconds = 90 },
                
                new { Id = 63, CreatedAt = new DateTime(2026, 01, 08, 16, 40, 03, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 01, 08, 16, 40, 09, DateTimeKind.Utc), UserId = "user3", WatchedDurationSeconds = 55, VideoDurationSeconds = 90 },
                
                new { Id = 64, CreatedAt = new DateTime(2026, 02, 02, 09, 14, 25, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 02, 02, 09, 14, 30, DateTimeKind.Utc), UserId = "user4", WatchedDurationSeconds = 77, VideoDurationSeconds = 90 },
                
                new { Id = 65, CreatedAt = new DateTime(2026, 02, 06, 11, 44, 10, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 02, 06, 11, 44, 15, DateTimeKind.Utc), UserId = "user5", WatchedDurationSeconds = 81, VideoDurationSeconds = 90 },
                
                new { Id = 66, CreatedAt = new DateTime(2026, 02, 11, 18, 03, 39, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 02, 11, 18, 03, 46, DateTimeKind.Utc), UserId = "user6", WatchedDurationSeconds = 49, VideoDurationSeconds = 90 },
                
                new { Id = 67, CreatedAt = new DateTime(2026, 03, 01, 08, 25, 55, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 03, 01, 08, 26, 01, DateTimeKind.Utc), UserId = "user7", WatchedDurationSeconds = 90, VideoDurationSeconds = 90 },
                
                new { Id = 68, CreatedAt = new DateTime(2026, 03, 04, 12, 18, 43, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 03, 04, 12, 18, 48, DateTimeKind.Utc), UserId = "user8", WatchedDurationSeconds = 61, VideoDurationSeconds = 90 },
                
                new { Id = 69, CreatedAt = new DateTime(2026, 03, 09, 15, 52, 16, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 03, 09, 15, 52, 22, DateTimeKind.Utc), UserId = "user9", WatchedDurationSeconds = 73, VideoDurationSeconds = 90 },
                
                new { Id = 70, CreatedAt = new DateTime(2026, 04, 02, 10, 33, 09, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 04, 02, 10, 33, 15, DateTimeKind.Utc), UserId = "user10", WatchedDurationSeconds = 86, VideoDurationSeconds = 90 },
                
                new { Id = 71, CreatedAt = new DateTime(2026, 04, 07, 14, 28, 34, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 04, 07, 14, 28, 39, DateTimeKind.Utc), UserId = "6031f4a7-b9f6-4246-8a42-b283e686b924", WatchedDurationSeconds = 44, VideoDurationSeconds = 90 },
                
                new { Id = 72, CreatedAt = new DateTime(2026, 04, 10, 17, 19, 20, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 04, 10, 17, 19, 26, DateTimeKind.Utc), UserId = "863f4ca1-c278-4f70-bae6-3d2f8756d1b8", WatchedDurationSeconds = 79, VideoDurationSeconds = 90 },
                
                new { Id = 73, CreatedAt = new DateTime(2026, 05, 01, 09, 42, 55, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 01, 09, 43, 01, DateTimeKind.Utc), UserId = "b044f332-fb0e-4534-aa99-95146799ce11", WatchedDurationSeconds = 66, VideoDurationSeconds = 90 },
                
                new { Id = 74, CreatedAt = new DateTime(2026, 05, 03, 11, 21, 17, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 03, 11, 21, 22, DateTimeKind.Utc), UserId = "e18e137f-7c29-4001-b83e-a208d829b922", WatchedDurationSeconds = 88, VideoDurationSeconds = 90 },
                
                new { Id = 75, CreatedAt = new DateTime(2026, 05, 06, 13, 05, 31, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 06, 13, 05, 37, DateTimeKind.Utc), UserId = "5dc249b0-0e39-4115-8783-a72f4853769f", WatchedDurationSeconds = 59, VideoDurationSeconds = 90 },
                new { Id = 76, CreatedAt = new DateTime(2026, 05, 08, 15, 44, 12, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 08, 15, 44, 18, DateTimeKind.Utc), UserId = "a1b093c9-407d-469a-b627-560cc17bc58b", WatchedDurationSeconds = 83, VideoDurationSeconds = 90 },
                
                new { Id = 77, CreatedAt = new DateTime(2026, 05, 10, 18, 12, 47, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 10, 18, 12, 52, DateTimeKind.Utc), UserId = "a29a661d-a579-460f-a6eb-3692308940fa", WatchedDurationSeconds = 71, VideoDurationSeconds = 90 },
                
                new { Id = 78, CreatedAt = new DateTime(2026, 05, 12, 20, 03, 15, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 12, 20, 03, 20, DateTimeKind.Utc), UserId = "cce0a80c-645f-4d41-9f76-c9257f5e8ca2", WatchedDurationSeconds = 52, VideoDurationSeconds = 90 },
                
                new { Id = 79, CreatedAt = new DateTime(2026, 05, 14, 09, 35, 26, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 14, 09, 35, 31, DateTimeKind.Utc), UserId = "80dae523-57bd-4001-8e49-49e706ddbf42", WatchedDurationSeconds = 90, VideoDurationSeconds = 90 },
                
                new { Id = 80, CreatedAt = new DateTime(2026, 05, 16, 11, 48, 03, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 16, 11, 48, 08, DateTimeKind.Utc), UserId = "9fe7187f-94ff-4066-adca-06c16f6a9354", WatchedDurationSeconds = 74, VideoDurationSeconds = 90 },
                
                new { Id = 81, CreatedAt = new DateTime(2026, 05, 18, 14, 17, 55, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 18, 14, 18, 01, DateTimeKind.Utc), UserId = "8cc53df0-2132-4049-891a-25685f28d239", WatchedDurationSeconds = 63, VideoDurationSeconds = 90 },
                
                new { Id = 82, CreatedAt = new DateTime(2026, 05, 20, 16, 24, 42, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 20, 16, 24, 47, DateTimeKind.Utc), UserId = "a4eed7dd-be40-4d0b-a09f-88ec773a2729", WatchedDurationSeconds = 58, VideoDurationSeconds = 90 },
                
                new { Id = 83, CreatedAt = new DateTime(2026, 05, 22, 18, 39, 14, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 22, 18, 39, 19, DateTimeKind.Utc), UserId = "30ffb205-5b5e-496a-b908-04503fef9536", WatchedDurationSeconds = 81, VideoDurationSeconds = 90 },
                
                new { Id = 84, CreatedAt = new DateTime(2026, 05, 24, 20, 55, 36, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 24, 20, 55, 42, DateTimeKind.Utc), UserId = "143bbea2-2c1c-4fde-a209-c3398e108114", WatchedDurationSeconds = 46, VideoDurationSeconds = 90 },
                
                new { Id = 85, CreatedAt = new DateTime(2026, 05, 26, 08, 14, 59, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 26, 08, 15, 04, DateTimeKind.Utc), UserId = "9c761ca5-4ac4-4b8c-8bc4-d9b39784bbab", WatchedDurationSeconds = 69, VideoDurationSeconds = 90 },
                
                new { Id = 86, CreatedAt = new DateTime(2026, 05, 27, 10, 28, 17, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 27, 10, 28, 22, DateTimeKind.Utc), UserId = "af7ca807-fa30-406a-856f-21a79c7a30df", WatchedDurationSeconds = 88, VideoDurationSeconds = 90 },
                
                new { Id = 87, CreatedAt = new DateTime(2026, 05, 28, 12, 47, 44, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 28, 12, 47, 50, DateTimeKind.Utc), UserId = "03e4e169-0421-4729-919c-5d0273a2c253", WatchedDurationSeconds = 54, VideoDurationSeconds = 90 },
                
                new { Id = 88, CreatedAt = new DateTime(2026, 05, 28, 14, 13, 28, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 28, 14, 13, 34, DateTimeKind.Utc), UserId = "289946f1-6c5b-440f-840a-3101e95bd08e", WatchedDurationSeconds = 90, VideoDurationSeconds = 90 },
                
                new { Id = 89, CreatedAt = new DateTime(2026, 05, 29, 16, 35, 11, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 29, 16, 35, 16, DateTimeKind.Utc), UserId = "4da22cf4-9b48-4a07-a289-5b8771ccbe31", WatchedDurationSeconds = 77, VideoDurationSeconds = 90 },
                
                new { Id = 90, CreatedAt = new DateTime(2026, 05, 30, 18, 52, 49, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 05, 30, 18, 52, 54, DateTimeKind.Utc), UserId = "464d46db-3dbb-4027-8522-dfd9e82a53a4", WatchedDurationSeconds = 61, VideoDurationSeconds = 90 },
                new { Id = 91, CreatedAt = new DateTime(2026, 06, 01, 09, 11, 15, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 01, 09, 11, 20, DateTimeKind.Utc), UserId = "b1b8e459-8881-49c8-abdf-3b819ebc31e0", WatchedDurationSeconds = 82, VideoDurationSeconds = 90 },
                
                new { Id = 92, CreatedAt = new DateTime(2026, 06, 02, 11, 24, 33, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 02, 11, 24, 39, DateTimeKind.Utc), UserId = "80988744-94d6-4cf9-a072-67346dfa50c5", WatchedDurationSeconds = 73, VideoDurationSeconds = 90 },
                
                new { Id = 93, CreatedAt = new DateTime(2026, 06, 03, 13, 37, 48, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 03, 13, 37, 54, DateTimeKind.Utc), UserId = "bfa86d96-6038-47f8-b887-1f0dea200757", WatchedDurationSeconds = 64, VideoDurationSeconds = 90 },
                
                new { Id = 94, CreatedAt = new DateTime(2026, 06, 04, 15, 45, 02, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 04, 15, 45, 07, DateTimeKind.Utc), UserId = "94032bbb-163b-4261-b43e-bfcb1f68ba5a", WatchedDurationSeconds = 58, VideoDurationSeconds = 90 },
                
                new { Id = 95, CreatedAt = new DateTime(2026, 06, 05, 17, 58, 14, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 05, 17, 58, 19, DateTimeKind.Utc), UserId = "0f31a706-bda4-4089-9768-a71b5572b946", WatchedDurationSeconds = 88, VideoDurationSeconds = 90 },
                
                new { Id = 96, CreatedAt = new DateTime(2026, 06, 06, 19, 12, 41, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 06, 19, 12, 46, DateTimeKind.Utc), UserId = "4c6fe27a-e5a4-4125-887e-ed287cba033b", WatchedDurationSeconds = 69, VideoDurationSeconds = 90 },
                
                new { Id = 97, CreatedAt = new DateTime(2026, 06, 07, 08, 29, 55, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 07, 08, 30, 01, DateTimeKind.Utc), UserId = "2a4e3c3b-22dd-452a-bf43-0db970d623a4", WatchedDurationSeconds = 76, VideoDurationSeconds = 90 },
                
                new { Id = 98, CreatedAt = new DateTime(2026, 06, 08, 10, 44, 27, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 08, 10, 44, 32, DateTimeKind.Utc), UserId = "1b6383e9-832d-42d1-a705-2c7cbb26cf45", WatchedDurationSeconds = 90, VideoDurationSeconds = 90 },
                
                new { Id = 99, CreatedAt = new DateTime(2026, 06, 09, 12, 57, 36, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 09, 12, 57, 42, DateTimeKind.Utc), UserId = "b8948849-72cc-4a80-a2e5-1650207648c1", WatchedDurationSeconds = 62, VideoDurationSeconds = 90 },
                
                new { Id = 100, CreatedAt = new DateTime(2026, 06, 10, 14, 16, 09, DateTimeKind.Utc), ReelId = 51, UpdatedAt = new DateTime(2026, 06, 10, 14, 16, 15, DateTimeKind.Utc), UserId = "5b9f37a1-574f-4456-b080-c3db91697535", WatchedDurationSeconds = 81, VideoDurationSeconds = 90 }


                ]);
        }
    }
}
