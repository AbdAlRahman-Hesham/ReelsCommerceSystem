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

            builder.HasKey(ui => new { ui.UserId, ui.InterestId });
            builder
                  .HasOne(ui => ui.User)
                  .WithMany(u => u.Interests)
                  .HasForeignKey(ui => ui.UserId);
            builder.HasOne(ui => ui.Interest)
                .WithMany(i => i.UserInterests)
                .HasForeignKey(ui => ui.InterestId);

        }
    }
}
