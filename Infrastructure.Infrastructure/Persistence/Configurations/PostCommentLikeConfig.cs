using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.CommunityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class PostCommentLikeConfig : IEntityTypeConfiguration<PostCommentLike>
    {
        public void Configure(EntityTypeBuilder<PostCommentLike> builder)
        {
            builder.HasIndex(l => new { l.BrandId, l.PostCommentId }).IsUnique();

            builder.HasOne(l => l.Brand)
                .WithMany(b => b.PostCommentLikes)
                .HasForeignKey(l => l.BrandId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(l => l.PostComment)
                .WithMany(c=>c.CommentLikes)
                .HasForeignKey(l => l.PostCommentId);

        }
    }
}
