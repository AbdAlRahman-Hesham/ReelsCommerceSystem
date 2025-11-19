using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;


namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ProductColorMappingSeeding : IEntityTypeConfiguration<ProductColorMapping>
{
    public void Configure(EntityTypeBuilder<ProductColorMapping> builder)
    {
        var productColorMappings = new List<ProductColorMapping>();
        int mappingId = 1;

        // Helper method to add color mappings with predetermined distributions
        void AddColorMappings(int productId, int totalQuantity, List<(int colorId, int percentage)> colorDistribution)
        {
            int remainingQuantity = totalQuantity;

            for (int i = 0; i < colorDistribution.Count; i++)
            {
                var (colorId, percentage) = colorDistribution[i];

                int colorQuantity;
                if (i == colorDistribution.Count - 1)
                {
                    // Last color gets remaining quantity to ensure total matches
                    colorQuantity = remainingQuantity;
                }
                else
                {
                    colorQuantity = (totalQuantity * percentage) / 100;
                    remainingQuantity -= colorQuantity;
                }

                productColorMappings.Add(new ProductColorMapping
                {
                    Id = mappingId++,
                    ProductId = productId,
                    ProductColorId = colorId,
                    Quantity = colorQuantity
                });
            }
        }

        // -------------------- Brand 1: NovaWear – Sustainable fashion --------------------
        AddColorMappings(1, 120, new List<(int, int)> { (4, 40), (5, 35), (3, 25) }); // EcoFlex T-Shirt - Black, White, Green
        AddColorMappings(2, 80, new List<(int, int)> { (2, 50), (4, 30), (1, 20) }); // ReVibe Denim Jacket - Blue, Black, Red
        AddColorMappings(3, 150, new List<(int, int)> { (4, 35), (2, 30), (5, 20), (1, 15) }); // EcoStride Sneakers - Black, Blue, White, Red
        AddColorMappings(4, 100, new List<(int, int)> { (3, 40), (5, 35), (10, 25) }); // Bamboo Breeze Hoodie - Green, White, Gray
        AddColorMappings(5, 200, new List<(int, int)> { (4, 45), (5, 30), (3, 25) }); // ReLeaf Tote Bag - Black, White, Green
        AddColorMappings(6, 90, new List<(int, int)> { (10, 40), (4, 35), (2, 25) }); // NatureFlow Pants - Gray, Black, Blue

        // -------------------- Brand 2: TechEase – Smart accessories --------------------
        AddColorMappings(7, 300, new List<(int, int)> { (4, 40), (2, 30), (5, 30) }); // SyncCharge Cable - Black, Blue, White
        AddColorMappings(8, 120, new List<(int, int)> { (4, 50), (10, 30), (5, 20) }); // SmartDock Pro - Black, Gray, White
        AddColorMappings(9, 200, new List<(int, int)> { (4, 45), (2, 30), (7, 25) }); // AirPulse Earbuds - Black, Blue, Purple
        AddColorMappings(10, 150, new List<(int, int)> { (4, 50), (10, 30), (5, 20) }); // MagGrip Phone Mount - Black, Gray, White
        AddColorMappings(11, 80, new List<(int, int)> { (4, 40), (2, 35), (1, 25) }); // PulseTrack Watch - Black, Blue, Red
        AddColorMappings(12, 180, new List<(int, int)> { (4, 35), (7, 25), (9, 20), (2, 20) }); // GlideCase - Black, Purple, Pink, Blue

        // -------------------- Brand 3: Glowify – Natural skincare --------------------
        // Skincare typically comes in standard packaging colors
        AddColorMappings(13, 120, new List<(int, int)> { (5, 60), (9, 40) }); // HydraBloom Serum - White, Pink
        AddColorMappings(14, 200, new List<(int, int)> { (5, 70), (3, 30) }); // PureDew Cleanser - White, Green
        AddColorMappings(15, 150, new List<(int, int)> { (5, 50), (2, 30), (7, 20) }); // LumiMist Toner - White, Blue, Purple
        AddColorMappings(16, 100, new List<(int, int)> { (5, 60), (9, 40) }); // Radiant Night Cream - White, Pink
        AddColorMappings(17, 180, new List<(int, int)> { (5, 55), (6, 45) }); // GlowShield Sunscreen - White, Yellow
        AddColorMappings(18, 160, new List<(int, int)> { (5, 65), (9, 35) }); // SilkTouch Moisturizer - White, Pink

        // -------------------- Brand 4: UrbanFuel – Premium streetwear --------------------
        AddColorMappings(19, 120, new List<(int, int)> { (4, 40), (10, 35), (1, 25) }); // StreetCore Hoodie - Black, Gray, Red
        AddColorMappings(20, 100, new List<(int, int)> { (4, 45), (10, 30), (2, 25) }); // UrbanFlex Joggers - Black, Gray, Blue
        AddColorMappings(21, 150, new List<(int, int)> { (4, 35), (1, 25), (2, 20), (6, 20) }); // FuelRunner Sneakers - Black, Red, Blue, Yellow
        AddColorMappings(22, 80, new List<(int, int)> { (2, 40), (4, 35), (1, 25) }); // CityWave Jacket - Blue, Black, Red
        AddColorMappings(23, 200, new List<(int, int)> { (4, 50), (2, 30), (1, 20) }); // SnapEdge Cap - Black, Blue, Red
        AddColorMappings(24, 140, new List<(int, int)> { (4, 40), (5, 35), (10, 25) }); // MetroLayer Tee - Black, White, Gray

        // -------------------- Brand 5: Zenora – Wellness lifestyle --------------------
        AddColorMappings(25, 110, new List<(int, int)> { (3, 40), (5, 35), (10, 25) }); // ZenMat Pro - Green, White, Gray
        AddColorMappings(26, 150, new List<(int, int)> { (5, 50), (7, 30), (9, 20) }); // AromaBliss Diffuser - White, Purple, Pink
        AddColorMappings(27, 180, new List<(int, int)> { (5, 45), (7, 30), (9, 25) }); // CalmWave Candle - White, Purple, Pink
        AddColorMappings(28, 160, new List<(int, int)> { (3, 35), (5, 35), (2, 30) }); // Balance Bottle - Green, White, Blue
        AddColorMappings(29, 200, new List<(int, int)> { (5, 60), (3, 40) }); // Focus Journal - White, Green
        AddColorMappings(30, 180, new List<(int, int)> { (5, 55), (7, 45) }); // Serenity Pillow Spray - White, Purple

        // -------------------- Brand 6: AeroFit – Smart fitness gear --------------------
        AddColorMappings(31, 130, new List<(int, int)> { (4, 40), (2, 35), (1, 25) }); // AeroTrack Smart Band - Black, Blue, Red
        AddColorMappings(32, 90, new List<(int, int)> { (4, 50), (10, 30), (5, 20) }); // FlexCore Dumbbells - Black, Gray, White
        AddColorMappings(33, 100, new List<(int, int)> { (4, 45), (1, 30), (2, 25) }); // PulsePro Chest Strap - Black, Red, Blue
        AddColorMappings(34, 140, new List<(int, int)> { (3, 40), (4, 35), (5, 25) }); // AeroMat Trainer - Green, Black, White
        AddColorMappings(35, 160, new List<(int, int)> { (2, 40), (4, 35), (5, 25) }); // HydraFuel Bottle - Blue, Black, White
        AddColorMappings(36, 200, new List<(int, int)> { (4, 35), (2, 25), (1, 20), (6, 20) }); // TrainLite Shorts - Black, Blue, Red, Yellow

        // -------------------- Brand 7: EcoNest – Eco-friendly home solutions --------------------
        AddColorMappings(37, 110, new List<(int, int)> { (3, 40), (5, 35), (10, 25) }); // EcoGlow Lamp - Green, White, Gray
        AddColorMappings(38, 100, new List<(int, int)> { (3, 35), (5, 30), (2, 20), (7, 15) }); // GreenWave Blanket - Green, White, Blue, Purple
        AddColorMappings(39, 180, new List<(int, int)> { (3, 45), (5, 30), (10, 25) }); // PlantPure Planter Set - Green, White, Gray
        AddColorMappings(40, 150, new List<(int, int)> { (5, 50), (3, 30), (8, 20) }); // EcoFresh Diffuser - White, Green, Orange
        AddColorMappings(41, 90, new List<(int, int)> { (5, 60), (10, 40) }); // PureBreeze Air Filter - White, Gray
        AddColorMappings(42, 200, new List<(int, int)> { (3, 40), (5, 35), (10, 25) }); // Harmony Coasters - Green, White, Gray

        // -------------------- Brand 8: ByteWave – Tech-driven accessories --------------------
        AddColorMappings(43, 150, new List<(int, int)> { (4, 45), (2, 30), (5, 25) }); // VoltSync Charger - Black, Blue, White
        AddColorMappings(44, 180, new List<(int, int)> { (4, 40), (10, 30), (2, 15), (1, 15) }); // StreamPad Mouse - Black, Gray, Blue, Red
        AddColorMappings(45, 220, new List<(int, int)> { (4, 50), (10, 30), (5, 20) }); // DataShell SSD Case - Black, Gray, White
        AddColorMappings(46, 140, new List<(int, int)> { (4, 40), (7, 25), (9, 20), (2, 15) }); // WavePods Mini - Black, Purple, Pink, Blue
        AddColorMappings(47, 200, new List<(int, int)> { (4, 25), (2, 20), (1, 20), (6, 18), (3, 17) }); // NeonLink Cable Set - Multi-color
        AddColorMappings(48, 130, new List<(int, int)> { (10, 45), (4, 35), (5, 20) }); // GlideStand Laptop Dock - Gray, Black, White

        // -------------------- Brand 9: PureGlow – Clean & ethical skincare --------------------
        AddColorMappings(49, 160, new List<(int, int)> { (5, 60), (3, 40) }); // AquaRenew Cleanser - White, Green
        AddColorMappings(50, 140, new List<(int, int)> { (5, 55), (9, 45) }); // BrightVeil Moisturizer - White, Pink
        AddColorMappings(51, 150, new List<(int, int)> { (3, 40), (5, 35), (10, 25) }); // PureCure Mask - Green, White, Gray
        AddColorMappings(52, 130, new List<(int, int)> { (5, 50), (7, 30), (9, 20) }); // GlowHydra Serum - White, Purple, Pink
        AddColorMappings(53, 120, new List<(int, int)> { (5, 60), (9, 40) }); // VitaLush Night Cream - White, Pink
        AddColorMappings(54, 160, new List<(int, int)> { (5, 55), (2, 45) }); // FreshTone Toner - White, Blue

        // -------------------- Brand 10: Trendora – Curated fashion for trendsetters --------------------
        AddColorMappings(55, 90, new List<(int, int)> { (7, 35), (4, 30), (1, 20), (9, 15) }); // VelvetEdge Dress - Purple, Black, Red, Pink
        AddColorMappings(56, 80, new List<(int, int)> { (6, 40), (8, 35), (1, 25) }); // UrbanGleam Jacket - Yellow, Orange, Red
        AddColorMappings(57, 120, new List<(int, int)> { (4, 30), (7, 25), (2, 20), (6, 15), (1, 10) }); // ChromaSneak Shoes - Multi-color
        AddColorMappings(58, 70, new List<(int, int)> { (4, 50), (7, 30), (9, 20) }); // LuxeLine Handbag - Black, Purple, Pink
        AddColorMappings(59, 150, new List<(int, int)> { (1, 30), (4, 25), (2, 20), (7, 15), (9, 10) }); // PulseFit Crop Top - Multi-color
        AddColorMappings(60, 200, new List<(int, int)> { (4, 45), (10, 30), (7, 25) }); // NeoAura Sunglasses - Black, Gray, Purple

        builder.HasData(productColorMappings);
    }
}