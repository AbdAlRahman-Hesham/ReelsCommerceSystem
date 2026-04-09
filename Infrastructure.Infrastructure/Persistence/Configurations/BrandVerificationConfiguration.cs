using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class BrandVerificationConfiguration : IEntityTypeConfiguration<BrandVerification>
    {
        public void Configure(EntityTypeBuilder<BrandVerification> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FullName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.NationalId)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(x => x.TaxNumber)
                .HasMaxLength(50);

            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(x => x.IdFrontImage).IsRequired();
            builder.Property(x => x.IdBackImage).IsRequired();
            builder.Property(x => x.SelfieImage).IsRequired();

            builder.HasOne(x => x.Brand)
                .WithOne(x => x.BrandVerification)
                .HasForeignKey<BrandVerification>(x => x.BrandId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
