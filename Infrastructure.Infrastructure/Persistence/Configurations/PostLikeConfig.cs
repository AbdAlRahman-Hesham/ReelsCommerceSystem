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
    public class PostLikeConfig : IEntityTypeConfiguration<PostLike>
    {
        public void Configure(EntityTypeBuilder<PostLike> builder)
        {
            builder.HasIndex(l => new { l.BrandId, l.PostId }).IsUnique();

            builder.HasOne(l => l.Brand)
                .WithMany(b => b.PostLikes)
                .HasForeignKey(l => l.BrandId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(l => l.Post)
                .WithMany(p => p.Likes)
                .HasForeignKey(l => l.PostId);
        }
    }
}
