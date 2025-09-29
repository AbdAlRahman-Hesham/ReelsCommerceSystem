using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ForumPostEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class ForumPostConfig : IEntityTypeConfiguration<ForumPost>
    {
        public void Configure(EntityTypeBuilder<ForumPost> builder)
        {

            builder.Property(fp => fp.Title)
               .IsRequired()
               .HasMaxLength(50);

            builder.Property(fp => fp.Content)
                .IsRequired()
                .HasMaxLength(2000);
        }
    }
}
