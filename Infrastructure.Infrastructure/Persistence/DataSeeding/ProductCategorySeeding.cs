using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;


namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ProductCategorySeeding : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasData([
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 1, Name = "Clothing", ArName = "ملابس", },
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 2, Name = "Footwear", ArName = "أحذية"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 3, Name = "Accessories", ArName = "إكسسوارات" },
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 4, Name = "Electronics", ArName = "إلكترونيات"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 5, Name = "Audio", ArName = "سماعات"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 6, Name = "Wearables", ArName = "أجهزة قابلة للارتداء"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 7, Name = "Skincare", ArName = "العناية بالبشرة"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 8, Name = "Outerwear", ArName = "الملابس الخارجية"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 9, Name = "Fitness", ArName = "لياقة بدنية"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 10, Name = "Wellness", ArName = "العافية"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 11, Name = "Home", ArName = "منزل"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 12, Name = "Stationery", ArName = "قرطاسية"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 13, Name = "Equipment", ArName = "معدات"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 14, Name = "Home Decor", ArName = "ديكور منزلي"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 15, Name = "Gardening", ArName = "بستنة"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 16, Name = "Home Fragrance", ArName = "عبير المنزل"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 17, Name = "Appliances", ArName = "أجهزة منزلية"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 18, Name = "Storage", ArName = "تخزين"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 19, Name = "Office", ArName = "مكتب"},
            new ProductCategory {ImageUrl="https://images.unsplash.com/photo-1542291026-7eec264c27ff", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), Id = 20, Name = "Apparel", ArName = "ملابس رياضية"}
        ]);
        
    }
}
