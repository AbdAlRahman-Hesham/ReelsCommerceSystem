using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Contracts;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence
{
    public class DbInitializer : IDbInitializer
    {
        private readonly AppDbContext _appDbContext;

        public DbInitializer(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task InitializeAsync()
        {
            if (_appDbContext.Database.GetPendingMigrations().Any())
            {
                await _appDbContext.Database.MigrateAsync();
            }

            if (!_appDbContext.Brands.Any())
            {
               
                var brandsData = await File.ReadAllTextAsync(
                    @"D:\Reels\Infrastructure.Infrastructure\Persistence\DataSeeding\Brands.json"
                );

                var brands = JsonSerializer.Deserialize<List<Brand>>(brandsData);

                if (brands is not null && brands.Any())
                {
                    await _appDbContext.Brands.AddRangeAsync(brands);
                    await _appDbContext.SaveChangesAsync();
                }
            }
        }
    }
}

