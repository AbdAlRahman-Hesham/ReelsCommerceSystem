using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ShippingCompanyEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ShippingCompanySeeding : IEntityTypeConfiguration<ShippingCompany>
{
    public void Configure(EntityTypeBuilder<ShippingCompany> builder)
    {
        builder.HasData(
            new ShippingCompany
            {
                Id = 1,
                Name = "Default Shipping Company",
                ContactEmail = "shipping@reelscommerce.com",
                ContactPhone = "01000000001",
                IsActive = true,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            }
        );
    }
}
