using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.TotalAmount)
                 .HasColumnType("decimal(18,2)");

            builder.Property(o => o.OrderStatus)
                   .HasConversion<string>()
                   .HasMaxLength(20);

            builder.Property(o => o.PaymentStatus)
                   .HasConversion<string>()
                   .HasMaxLength(20);

            builder.HasOne(o => o.User)
                    .WithMany()
                    .HasForeignKey(o => o.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
