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
    public class PostCommentConfig : IEntityTypeConfiguration<PostComment>
    {
        public void Configure(EntityTypeBuilder<PostComment> builder)
        {
            builder.HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostId);

            builder.HasOne(c => c.Brand)
                .WithMany(b=>b.PostComments)
                .HasForeignKey(c => c.BrandId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.CommentLikes)
                .WithOne(l => l.PostComment)
                .HasForeignKey(l => l.PostCommentId);

            builder.HasOne(r => r.ParentComment)
                .WithMany(c => c.Replies)
                .HasForeignKey(r => r.ParentCommentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
