using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding
{
    public class UserProductViewSeeding : IEntityTypeConfiguration<UserProductView>
    {
        private static readonly DateTime _staticSeedDate = new DateTime(2025, 12, 9, 0, 0, 0, DateTimeKind.Utc);

        public void Configure(EntityTypeBuilder<UserProductView> builder)
        {
            builder.HasData(
            
              new UserProductView { Id = 1, UserId = "user1", ProductId = 1, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },
              new UserProductView { Id = 2, UserId = "user1", ProductId = 2, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },
              new UserProductView { Id = 3, UserId = "user1", ProductId = 3, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },

              
              new UserProductView { Id = 4, UserId = "user2", ProductId = 2, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },
              new UserProductView { Id = 5, UserId = "user2", ProductId = 4, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },
              new UserProductView { Id = 6, UserId = "user2", ProductId = 5, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },

          
              new UserProductView { Id = 7, UserId = "user3", ProductId = 1, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },
              new UserProductView { Id = 8, UserId = "user3", ProductId = 6, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },
              new UserProductView { Id = 9, UserId = "user3", ProductId = 3, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },

              
              new UserProductView { Id = 10, UserId = "user4", ProductId = 2, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate },
              new UserProductView { Id = 11, UserId = "user4", ProductId = 5, CreatedAt = _staticSeedDate, UpdatedAt = _staticSeedDate }
          );

        }
    }
}
