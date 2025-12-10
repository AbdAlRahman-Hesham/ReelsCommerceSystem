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
    public class ReelCommentReplySeeding : IEntityTypeConfiguration<ReelCommentReply>
    {
        private static readonly DateTime _seedDate =
        new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public void Configure(EntityTypeBuilder<ReelCommentReply> builder)
        {
            builder.HasData([
                new()
            {
                Id = 1,
                Content = "Totally agree with you! 🔥",
                ParentCommentId = 1,
                UserId = "user2",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 2,
                Content = "Same question! 😂",
                ParentCommentId = 3,
                UserId = "user7",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 3,
                Content = "Yes available worldwide 🌍",
                ParentCommentId = 5,
                UserId = "user4",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            },
            new()
            {
                Id = 4,
                Content = "High quality indeed 💯",
                ParentCommentId = 4,
                UserId = "user6",
                CreatedAt = _seedDate,
                UpdatedAt = _seedDate
            }
            ]);
        }
    }
}

