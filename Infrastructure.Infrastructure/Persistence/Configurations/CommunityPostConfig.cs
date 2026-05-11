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
    public class CommunityPostConfig : IEntityTypeConfiguration<CommunityPost>
    {
        public void Configure(EntityTypeBuilder<CommunityPost> builder)
        {
            builder.HasIndex(p => p.Slug).IsUnique();

            builder.HasOne(p => p.Brand).
                WithMany(b => b.Posts).
                HasForeignKey(p => p.BrandId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.Comments).
                WithOne(c => c.Post).
                HasForeignKey(c => c.PostId);

            builder.HasMany(p => p.Likes).
                WithOne(l => l.Post).
                HasForeignKey(l => l.PostId);


        }
    }
}
