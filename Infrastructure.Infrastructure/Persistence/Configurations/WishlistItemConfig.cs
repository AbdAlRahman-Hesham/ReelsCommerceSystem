using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class WishlistItemConfig : IEntityTypeConfiguration<WishlistItem>
    {
        public void Configure(EntityTypeBuilder<WishlistItem> builder)
        {
            builder.ToTable("WishlistItems");

            builder.HasIndex(w => new { w.UserId, w.ProductId }).IsUnique();

            builder.HasOne(item=>item.User)
                   .WithMany(u => u.WishlistItems)
                   .HasForeignKey(item => item.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(item => item.Product)
                   .WithMany(p => p.WishlistItems)
                   .HasForeignKey(item => item.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(item => item.CreatedAt).IsRequired();
        }
    }
}
