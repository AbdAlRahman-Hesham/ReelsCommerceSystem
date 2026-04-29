using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.Products;
using System.Buffers.Text;


namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ProductSeeding : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {


        builder.HasData(new Product[]

{
     // -------------------- Brand 1: NovaWear – Sustainable fashion --------------------
    new Product {   Id = 1, Name = "EcoFlex T-Shirt", Description = "Breathable organic cotton tee for everyday comfort.", CategoryId = 1, Price = 180.00m, IsCustomizable = false, DiscountPercentage = 10, BrandId = 1  },
    new Product {   Id = 2, Name = "ReVibe Denim Jacket", Description = "Stylish recycled denim jacket for a sustainable look.", CategoryId = 1, Price = 420.00m, IsCustomizable = true, DiscountPercentage = 20, BrandId = 1  },
    new Product {   Id = 3, Name = "EcoStride Sneakers", Description = "Lightweight sneakers made from recycled fibers.", CategoryId = 2, Price = 360.00m, IsCustomizable = false, DiscountPercentage = 30, BrandId = 1 },
    new Product {   Id = 4, Name = "Bamboo Breeze Hoodie", Description = "Soft hoodie crafted from sustainable bamboo fabric.", CategoryId = 1, Price = 280.00m, IsCustomizable = true, DiscountPercentage = 40, BrandId = 1 },
    new Product {   Id = 5, Name = "ReLeaf Tote Bag", Description = "Eco-friendly tote bag with minimalist design.", CategoryId = 3, Price = 150.00m, IsCustomizable = false, BrandId = 1 },
    new Product {   Id = 6, Name = "NatureFlow Pants", Description = "Comfortable pants made from recycled polyester.", CategoryId = 1, Price = 310.00m, IsCustomizable = false, BrandId = 1 },

    // -------------------- Brand 2: TechEase – Smart accessories --------------------
    new Product {   Id = 7, Name = "SyncCharge Cable", Description = "Fast-charging braided USB-C cable with smart chip.", CategoryId = 4, Price = 180.00m, DiscountPercentage = 10, BrandId = 2},
    new Product {   Id = 8, Name = "SmartDock Pro", Description = "Multi-device charging dock with wireless pad.", CategoryId = 4, Price = 420.00m, DiscountPercentage = 20, BrandId = 2 },
    new Product {   Id = 9, Name = "AirPulse Earbuds", Description = "Noise-cancelling Bluetooth earbuds with 24h battery.", CategoryId = 5, Price = 540.00m, DiscountPercentage = 30, BrandId = 2 },
    new Product {   Id = 10, Name = "MagGrip Phone Mount", Description = "Smart magnetic car mount with auto-lock system.", CategoryId = 3, Price = 190.00m, DiscountPercentage = 40, BrandId = 2 },
    new Product {   Id = 11, Name = "PulseTrack Watch", Description = "Fitness smartwatch with heart-rate and sleep tracking.", CategoryId = 6, Price = 690.00m, BrandId = 2 },
    new Product {   Id = 12, Name = "GlideCase", Description = "MagSafe-compatible slim phone case.", CategoryId = 3, Price = 160.00m, BrandId = 2 },

    // -------------------- Brand 3: Glowify – Natural skincare --------------------
    new Product {   Id = 13, Name = "HydraBloom Serum", Description = "Vitamin C serum that brightens and smooths skin.", CategoryId = 7, Price = 250.00m, DiscountPercentage = 10, BrandId = 3 },
    new Product {   Id = 14, Name = "PureDew Cleanser", Description = "Gentle cleanser with aloe and green tea.", CategoryId = 7, Price = 180.00m, DiscountPercentage = 20, BrandId = 3 },
    new Product {   Id = 15, Name = "LumiMist Toner", Description = "Hydrating toner that refines pores naturally.", CategoryId = 7, Price = 210.00m, DiscountPercentage = 30, BrandId = 3 },
    new Product {   Id = 16, Name = "Radiant Night Cream", Description = "Rich moisturizer for overnight skin repair.", CategoryId = 7, Price = 330.00m, DiscountPercentage = 40, BrandId = 3 },
    new Product {   Id = 17, Name = "GlowShield Sunscreen", Description = "SPF 50 mineral sunscreen with lightweight feel.", CategoryId = 7, Price = 290.00m, BrandId = 3 },
    new Product {   Id = 18, Name = "SilkTouch Moisturizer", Description = "All-day hydration for sensitive skin.", CategoryId = 7, Price = 270.00m, BrandId = 3 },

    // -------------------- Brand 4: UrbanFuel – Premium streetwear --------------------
    new Product {   Id = 19, Name = "StreetCore Hoodie", Description = "Oversized hoodie with minimalist street-style logo.", CategoryId = 1, Price = 320.00m, DiscountPercentage = 10, BrandId = 4 },
    new Product {   Id = 20, Name = "UrbanFlex Joggers", Description = "Slim-fit joggers for comfort and performance.", CategoryId = 1, Price = 270.00m, DiscountPercentage = 20, BrandId = 4 },
    new Product {   Id = 21, Name = "FuelRunner Sneakers", Description = "Modern street sneakers with breathable mesh upper.", CategoryId = 2, Price = 540.00m, DiscountPercentage = 30, BrandId = 4 },
    new Product {   Id = 22, Name = "CityWave Jacket", Description = "Lightweight windbreaker with waterproof coating.", CategoryId = 8, Price = 620.00m, DiscountPercentage = 40, BrandId = 4 },
    new Product {   Id = 23, Name = "SnapEdge Cap", Description = "Classic snapback cap with embroidered logo.", CategoryId = 3, Price = 180.00m, BrandId = 4 },
    new Product {   Id = 24, Name = "MetroLayer Tee", Description = "Soft cotton tee with subtle reflective branding.", CategoryId = 1, Price = 190.00m, BrandId = 4 },

    // -------------------- Brand 5: Zenora – Wellness lifestyle --------------------
    new Product {   Id = 25, Name = "ZenMat Pro", Description = "Premium non-slip yoga mat made with eco rubber.", CategoryId = 9, Price = 350.00m, DiscountPercentage = 10, BrandId = 5 },
    new Product {   Id = 26, Name = "AromaBliss Diffuser", Description = "Ultrasonic diffuser with ambient lighting.", CategoryId = 10, Price = 290.00m, DiscountPercentage = 20, BrandId = 5 },
    new Product {   Id = 27, Name = "CalmWave Candle", Description = "Soy candle infused with lavender and chamomile.", CategoryId = 11, Price = 170.00m, DiscountPercentage = 30, BrandId = 5 },
    new Product {   Id = 28, Name = "Balance Bottle", Description = "Glass water bottle with bamboo lid and sleeve.", CategoryId = 10, Price = 210.00m, DiscountPercentage = 40, BrandId = 5 },
    new Product {   Id = 29, Name = "Focus Journal", Description = "Guided journal for mindfulness and productivity.", CategoryId = 12, Price = 150.00m, BrandId = 5 },
    new Product {   Id = 30, Name = "Serenity Pillow Spray", Description = "Natural lavender mist for better sleep.", CategoryId = 10, Price = 180.00m, BrandId = 5 },

    // -------------------- Brand 6: AeroFit – Smart fitness gear --------------------
    new Product {   Id = 31, Name = "AeroTrack Smart Band", Description = "Fitness tracker with pulse and oxygen monitoring.", CategoryId = 6, Price = 540.00m, DiscountPercentage = 10, BrandId = 6 },
    new Product {   Id = 32, Name = "FlexCore Dumbbells", Description = "Adjustable dumbbells for home strength training.", CategoryId = 13, Price = 720.00m, DiscountPercentage = 20, BrandId = 6 },
    new Product {   Id = 33, Name = "PulsePro Chest Strap", Description = "Heart-rate strap compatible with popular apps.", CategoryId = 3, Price = 210.00m, DiscountPercentage = 30, BrandId = 6 },
    new Product {   Id = 34, Name = "AeroMat Trainer", Description = "High-density mat ideal for HIIT and yoga.", CategoryId = 9, Price = 250.00m, DiscountPercentage = 40, BrandId = 6 },
    new Product {   Id = 35, Name = "HydraFuel Bottle", Description = "Smart bottle that tracks hydration levels.", CategoryId = 3, Price = 170.00m, BrandId = 6 },
    new Product {   Id = 36, Name = "TrainLite Shorts", Description = "Lightweight shorts with moisture-wicking tech.", CategoryId = 14, Price = 260.00m, BrandId = 6 },

    // -------------------- Brand 7: EcoNest – Eco-friendly home solutions --------------------
    new Product {   Id = 37, Name = "EcoGlow Lamp", Description = "Bamboo desk lamp with rechargeable LED bulb.", CategoryId = 15, Price = 250.00m, DiscountPercentage = 10, BrandId = 7 },
    new Product {   Id = 38, Name = "GreenWave Blanket", Description = "Soft throw blanket made from recycled cotton.", CategoryId = 11, Price = 320.00m, DiscountPercentage = 20, BrandId = 7 },
    new Product {   Id = 39, Name = "PlantPure Planter Set", Description = "Biodegradable planters perfect for indoor herbs.", CategoryId = 16, Price = 180.00m, DiscountPercentage = 30, BrandId = 7 },
    new Product {   Id = 40, Name = "EcoFresh Diffuser", Description = "Natural reed diffuser with citrus essential oils.", CategoryId = 17, Price = 210.00m, DiscountPercentage = 40, BrandId = 7 },
    new Product {   Id = 41, Name = "PureBreeze Air Filter", Description = "Reusable air filter system for cleaner home air.", CategoryId = 18, Price = 640.00m, BrandId = 7 },
    new Product {   Id = 42, Name = "Harmony Coasters", Description = "Cork coasters made from renewable materials.", CategoryId = 16, Price = 160.00m, BrandId = 7 },

    // -------------------- Brand 8: ByteWave – Tech-driven accessories --------------------
    new Product {   Id = 43, Name = "VoltSync Charger", Description = "High-speed GaN charger with dual USB-C output.", CategoryId = 4, Price = 280.00m, DiscountPercentage = 10, BrandId = 8 },
    new Product {   Id = 44, Name = "StreamPad Mouse", Description = "Ergonomic wireless mouse with silent clicks.", CategoryId = 3, Price = 240.00m, DiscountPercentage = 20, BrandId = 8 },
    new Product {   Id = 45, Name = "DataShell SSD Case", Description = "Shockproof case for portable SSDs.", CategoryId = 18, Price = 190.00m, DiscountPercentage = 30, BrandId = 8 },
    new Product {   Id = 46, Name = "WavePods Mini", Description = "Compact true wireless earbuds with clear audio.", CategoryId = 5, Price = 420.00m, DiscountPercentage = 40, BrandId = 8 },
    new Product {   Id = 47, Name = "NeonLink Cable Set", Description = "Color-coded USB-C and Lightning cable pack.", CategoryId = 3, Price = 160.00m, BrandId = 8 },
    new Product {   Id = 48, Name = "GlideStand Laptop Dock", Description = "Foldable aluminum laptop stand with cooling vents.", CategoryId = 19, Price = 360.00m, BrandId = 8 },

    // -------------------- Brand 9: PureGlow – Clean & ethical skincare --------------------
    new Product {   Id = 49, Name = "AquaRenew Cleanser", Description = "Refreshing foaming cleanser for daily use.", CategoryId = 7, Price = 180.00m, DiscountPercentage = 10, BrandId = 9 },
    new Product {   Id = 50, Name = "BrightVeil Moisturizer", Description = "Lightweight daily cream with niacinamide for radiant skin.", CategoryId = 7, Price = 220.00m, DiscountPercentage = 20, BrandId = 9 },
    new Product {   Id = 51, Name = "PureCure Mask", Description = "Detoxifying clay mask that purifies pores naturally.", CategoryId = 7, Price = 240.00m, DiscountPercentage = 30, BrandId = 9 },
    new Product {   Id = 52, Name = "GlowHydra Serum", Description = "Deep hydration serum enriched with hyaluronic acid.", CategoryId = 7, Price = 390.00m, DiscountPercentage = 40, BrandId = 9 },
    new Product {   Id = 53, Name = "VitaLush Night Cream", Description = "Nourishing night cream with plant-based peptides.", CategoryId = 7, Price = 260.00m, BrandId = 9 },
    new Product {   Id = 54, Name = "FreshTone Toner", Description = "Balancing toner that smooths skin and reduces shine.", CategoryId = 7, Price = 210.00m, BrandId = 9 },

    // -------------------- Brand 10: Trendora – Curated fashion --------------------
    new Product {   Id = 55, Name = "VelvetEdge Dress", Description = "Chic velvet dress perfect for evening occasions.", CategoryId = 1, Price = 780.00m, DiscountPercentage = 10, BrandId = 10 },
    new Product {   Id = 56, Name = "UrbanGleam Jacket", Description = "Metallic cropped jacket for a bold statement look.", CategoryId = 8, Price = 650.00m, DiscountPercentage = 20, BrandId = 10 },
    new Product {   Id = 57, Name = "ChromaSneak Shoes", Description = "Color-shifting sneakers that stand out everywhere.", CategoryId = 2, Price = 540.00m, DiscountPercentage = 30, BrandId = 10 },
    new Product {   Id = 58, Name = "LuxeLine Handbag", Description = "Elegant faux-leather handbag with gold accents.", CategoryId = 3, Price = 720.00m, DiscountPercentage = 40, BrandId = 10 },
    new Product {   Id = 59, Name = "PulseFit Crop Top", Description = "Trendy cropped top for modern streetwear style.", CategoryId = 1, Price = 190.00m, BrandId = 10 },
    new Product {   Id = 60, Name = "NeoAura Sunglasses", Description = "Retro-futuristic shades with UV400 protection.", CategoryId = 3, Price = 350.00m, BrandId = 10 }
});
    }
}
