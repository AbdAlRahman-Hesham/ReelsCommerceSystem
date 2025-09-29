using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.UserInterestEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class UserInterestConfig : IEntityTypeConfiguration<UserInterest>
    {
        public void Configure(EntityTypeBuilder<UserInterest> builder)
        {
            builder.HasKey(ui => new { ui.UserId, ui.Interests });

            builder.Property(ui => ui.Interests)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
