using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class UserProductViewConfig : IEntityTypeConfiguration<UserProductView>
{
    public void Configure(EntityTypeBuilder<UserProductView> builder)
    {
        builder.HasIndex(uv => new { uv.UserId, uv.ProductId })
            .IsUnique();
    }
}
