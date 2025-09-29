using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class OrderProductConfig : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {

            builder.HasKey(op => new { op.OrderId, op.ProductId });
            builder.Property(op => op.Price).HasColumnType("decimal(18,2)");

        }
    }
}
