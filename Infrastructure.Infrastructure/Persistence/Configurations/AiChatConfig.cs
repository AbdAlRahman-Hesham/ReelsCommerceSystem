using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.AiChatsEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class AiChatConfig : IEntityTypeConfiguration<AiChat>
    {
        public void Configure(EntityTypeBuilder<AiChat> builder)
        {
            builder.Property(c => c.GeneratedImages) 
            .HasColumnType("nvarchar(max)");
        }
    }
}
