using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class BrandSocialLinkConfig : IEntityTypeConfiguration<BrandSocialLink>
{
    public void Configure(EntityTypeBuilder<BrandSocialLink> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Platform)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Url)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasOne(x => x.Brand)
            .WithMany(b => b.SocialLinks)
            .HasForeignKey(x => x.BrandId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
