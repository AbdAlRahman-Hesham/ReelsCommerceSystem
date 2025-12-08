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
    public class ReelCommentLoveSeeding: IEntityTypeConfiguration<ReelCommentLove>
    {
        private static readonly DateTime _seedDate =
        new DateTime(2025, 1, 3, 0, 0, 0, DateTimeKind.Utc);

        public void Configure(EntityTypeBuilder<ReelCommentLove> builder)
        {
            builder.HasData([
                new()
            {
                Id = 1,
                ReelCommentId = 1,  
                UserId = "user2", 
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 2,
                ReelCommentId = 1,
                UserId = "user3",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 3,
                ReelCommentId = 2,
                UserId = "user1",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 4,
                ReelCommentId = 3,
                UserId = "user8",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 5,
                ReelCommentId = 4,
                UserId = "user1",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            }
            ]);
        }
    }
}
