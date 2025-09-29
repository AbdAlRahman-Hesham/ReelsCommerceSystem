using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductCartEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class ProductCartConfig : IEntityTypeConfiguration<ProductCart>
    {
        public void Configure(EntityTypeBuilder<ProductCart> builder)
        {
            builder.HasKey(pc => new { pc.CartId, pc.ProductId });
        }
    }
}
