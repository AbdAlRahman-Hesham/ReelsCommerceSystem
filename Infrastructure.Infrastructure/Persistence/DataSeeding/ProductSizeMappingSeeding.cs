using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;


namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

/*public class ProductSizeMappingSeeding : IEntityTypeConfiguration<ProductSizeMapping>
{
    public void Configure(EntityTypeBuilder<ProductSizeMapping> builder)
    {
        var productSizeMappings = new List<ProductSizeMapping>();

        int mappingId = 1;

        // Helper method to add size mappings with predetermined distributions
        void AddSizeMappings(int productId, int totalQuantity, List<(int sizeId, int percentage)> sizeDistribution)
        {
            int remainingQuantity = totalQuantity;

            for (int i = 0; i < sizeDistribution.Count; i++)
            {
                var (sizeId, percentage) = sizeDistribution[i];

                int sizeQuantity;
                if (i == sizeDistribution.Count - 1)
                {
                    // Last size gets remaining quantity to ensure total matches
                    sizeQuantity = remainingQuantity;
                }
                else
                {
                    sizeQuantity = (totalQuantity * percentage) / 100;
                    remainingQuantity -= sizeQuantity;
                }

                productSizeMappings.Add(new ProductSizeMapping
                {
                    Id = mappingId++,
                    ProductSizeId = sizeId,
                    Quantity = sizeQuantity
                });
            }
        }

        // -------------------- Brand 1: NovaWear – Sustainable fashion (Clothing) --------------------
        AddSizeMappings(1, 120, new List<(int, int)> { (1, 15), (2, 20), (3, 25), (4, 25), (5, 15) }); // XS, S, M, L, XL
        AddSizeMappings(2, 80, new List<(int, int)> { (2, 25), (3, 30), (4, 30), (5, 15) }); // S, M, L, XL
        AddSizeMappings(3, 150, new List<(int, int)> { (3, 20), (4, 25), (5, 30), (6, 25) }); // M, L, XL, XXL
        AddSizeMappings(4, 100, new List<(int, int)> { (1, 10), (2, 20), (3, 30), (4, 25), (5, 15) }); // XS, S, M, L, XL
        AddSizeMappings(5, 200, new List<(int, int)> { (3, 40), (4, 35), (5, 25) }); // M, L, XL
        AddSizeMappings(6, 90, new List<(int, int)> { (2, 20), (3, 30), (4, 30), (5, 20) }); // S, M, L, XL

        // -------------------- Brand 2: TechEase – Smart accessories (Mixed) --------------------
        // Non-clothing items - single size
        AddSizeMappings(7, 300, new List<(int, int)> { (3, 100) }); // SyncCharge Cable
        AddSizeMappings(8, 120, new List<(int, int)> { (3, 100) }); // SmartDock Pro
        AddSizeMappings(9, 200, new List<(int, int)> { (3, 100) }); // AirPulse Earbuds
        AddSizeMappings(10, 150, new List<(int, int)> { (3, 100) }); // MagGrip Phone Mount
        AddSizeMappings(11, 80, new List<(int, int)> { (3, 100) }); // PulseTrack Watch

        // Clothing accessory - multiple sizes
        AddSizeMappings(12, 180, new List<(int, int)> { (2, 25), (3, 35), (4, 25), (5, 15) }); // GlideCase

        // -------------------- Brand 3: Glowify – Natural skincare (Non-clothing) --------------------
        AddSizeMappings(13, 120, new List<(int, int)> { (3, 100) }); // HydraBloom Serum
        AddSizeMappings(14, 200, new List<(int, int)> { (3, 100) }); // PureDew Cleanser
        AddSizeMappings(15, 150, new List<(int, int)> { (3, 100) }); // LumiMist Toner
        AddSizeMappings(16, 100, new List<(int, int)> { (3, 100) }); // Radiant Night Cream
        AddSizeMappings(17, 180, new List<(int, int)> { (3, 100) }); // GlowShield Sunscreen
        AddSizeMappings(18, 160, new List<(int, int)> { (3, 100) }); // SilkTouch Moisturizer

        // -------------------- Brand 4: UrbanFuel – Premium streetwear (Clothing) --------------------
        AddSizeMappings(19, 120, new List<(int, int)> { (1, 10), (2, 20), (3, 30), (4, 25), (5, 15) }); // StreetCore Hoodie
        AddSizeMappings(20, 100, new List<(int, int)> { (2, 25), (3, 35), (4, 25), (5, 15) }); // UrbanFlex Joggers
        AddSizeMappings(21, 150, new List<(int, int)> { (3, 20), (4, 30), (5, 30), (6, 20) }); // FuelRunner Sneakers
        AddSizeMappings(22, 80, new List<(int, int)> { (3, 30), (4, 35), (5, 35) }); // CityWave Jacket
        AddSizeMappings(23, 200, new List<(int, int)> { (1, 15), (2, 25), (3, 30), (4, 20), (5, 10) }); // SnapEdge Cap
        AddSizeMappings(24, 140, new List<(int, int)> { (2, 20), (3, 35), (4, 30), (5, 15) }); // MetroLayer Tee

        // -------------------- Brand 5: Zenora – Wellness lifestyle (Non-clothing) --------------------
        AddSizeMappings(25, 110, new List<(int, int)> { (3, 100) }); // ZenMat Pro
        AddSizeMappings(26, 150, new List<(int, int)> { (3, 100) }); // AromaBliss Diffuser
        AddSizeMappings(27, 180, new List<(int, int)> { (3, 100) }); // CalmWave Candle
        AddSizeMappings(28, 160, new List<(int, int)> { (3, 100) }); // Balance Bottle
        AddSizeMappings(29, 200, new List<(int, int)> { (3, 100) }); // Focus Journal
        AddSizeMappings(30, 180, new List<(int, int)> { (3, 100) }); // Serenity Pillow Spray

        // -------------------- Brand 6: AeroFit – Smart fitness gear (Mixed) --------------------
        AddSizeMappings(31, 130, new List<(int, int)> { (3, 100) }); // AeroTrack Smart Band
        AddSizeMappings(32, 90, new List<(int, int)> { (3, 100) }); // FlexCore Dumbbells
        AddSizeMappings(33, 100, new List<(int, int)> { (3, 100) }); // PulsePro Chest Strap
        AddSizeMappings(34, 140, new List<(int, int)> { (3, 100) }); // AeroMat Trainer
        AddSizeMappings(35, 160, new List<(int, int)> { (3, 100) }); // HydraFuel Bottle
        AddSizeMappings(36, 200, new List<(int, int)> { (2, 20), (3, 30), (4, 30), (5, 20) }); // TrainLite Shorts

        // -------------------- Brand 7: EcoNest – Eco-friendly home solutions (Non-clothing) --------------------
        AddSizeMappings(37, 110, new List<(int, int)> { (3, 100) }); // EcoGlow Lamp
        AddSizeMappings(38, 100, new List<(int, int)> { (3, 100) }); // GreenWave Blanket
        AddSizeMappings(39, 180, new List<(int, int)> { (3, 100) }); // PlantPure Planter Set
        AddSizeMappings(40, 150, new List<(int, int)> { (3, 100) }); // EcoFresh Diffuser
        AddSizeMappings(41, 90, new List<(int, int)> { (3, 100) }); // PureBreeze Air Filter
        AddSizeMappings(42, 200, new List<(int, int)> { (3, 100) }); // Harmony Coasters

        // -------------------- Brand 8: ByteWave – Tech-driven accessories (Non-clothing) --------------------
        AddSizeMappings(43, 150, new List<(int, int)> { (3, 100) }); // VoltSync Charger
        AddSizeMappings(44, 180, new List<(int, int)> { (3, 100) }); // StreamPad Mouse
        AddSizeMappings(45, 220, new List<(int, int)> { (3, 100) }); // DataShell SSD Case
        AddSizeMappings(46, 140, new List<(int, int)> { (3, 100) }); // WavePods Mini
        AddSizeMappings(47, 200, new List<(int, int)> { (3, 100) }); // NeonLink Cable Set
        AddSizeMappings(48, 130, new List<(int, int)> { (3, 100) }); // GlideStand Laptop Dock

        // -------------------- Brand 9: PureGlow – Clean & ethical skincare (Non-clothing) --------------------
        AddSizeMappings(49, 160, new List<(int, int)> { (3, 100) }); // AquaRenew Cleanser
        AddSizeMappings(50, 140, new List<(int, int)> { (3, 100) }); // BrightVeil Moisturizer
        AddSizeMappings(51, 150, new List<(int, int)> { (3, 100) }); // PureCure Mask
        AddSizeMappings(52, 130, new List<(int, int)> { (3, 100) }); // GlowHydra Serum
        AddSizeMappings(53, 120, new List<(int, int)> { (3, 100) }); // VitaLush Night Cream
        AddSizeMappings(54, 160, new List<(int, int)> { (3, 100) }); // FreshTone Toner

        // -------------------- Brand 10: Trendora – Curated fashion for trendsetters (Mixed) --------------------
        AddSizeMappings(55, 90, new List<(int, int)> { (1, 15), (2, 25), (3, 30), (4, 20), (5, 10) }); // VelvetEdge Dress
        AddSizeMappings(56, 80, new List<(int, int)> { (2, 25), (3, 35), (4, 25), (5, 15) }); // UrbanGleam Jacket
        AddSizeMappings(57, 120, new List<(int, int)> { (3, 100) }); // ChromaSneak Shoes
        AddSizeMappings(58, 70, new List<(int, int)> { (3, 100) }); // LuxeLine Handbag
        AddSizeMappings(59, 150, new List<(int, int)> { (1, 10), (2, 25), (3, 35), (4, 20), (5, 10) }); // PulseFit Crop Top
        AddSizeMappings(60, 200, new List<(int, int)> { (3, 100) }); // NeoAura Sunglasses

        builder.HasData(productSizeMappings);
    }
}
*/