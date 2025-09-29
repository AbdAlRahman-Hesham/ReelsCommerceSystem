using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.UserOrderEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class UserOrderConfig : IEntityTypeConfiguration<UserOrder>
    {
        public void Configure(EntityTypeBuilder<UserOrder> builder)
        {
            builder.HasKey(uo => new { uo.UserId, uo.OrderId });
        }
    }
}
