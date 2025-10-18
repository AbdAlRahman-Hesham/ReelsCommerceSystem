using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand1/EcoFlexT-Shirt.png", 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand1/ReVibe Denim Jacket.jfif", 420.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand1/EcoStride Sneakers.jfif", 360.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand1/Bamboo Breeze Hoodie.png", 280.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand1/ReLeaf Tote Bag.jfif", 150.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand1/NatureFlow Pants.webp", 310.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand2/SyncCharge Cable.jfif", 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand2/SmartDock Pro.jfif", 420.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand2/AirPulse Earbuds.jfif", 540.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand2/MagGrip Phone Mount.jfif", 190.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand2/PulseTrack Watch.jfif", 690.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand2/GlideCase.jfif", 160.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand3/HydraBloom Serum.jpg", 250.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand3/PureDew Cleanser.png", 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand3/LumiMist Toner.webp", 210.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand3/Radiant Night Cream.webp", 330.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand3/GlowShield Sunscreen.jpg", 290.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand3/SilkTouch Moisturizer.png", 270.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand4/StreetCore Hoodie.png", 320.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand4/UrbanFlex Joggers.png", 270.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand4/FuelRunner Sneakers.png", 540.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand4/CityWave Jacket.png", 620.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand4/SnapEdge Cap.webp", 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand4/MetroLayer Tee.jpg", 190.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand5/ZenMat.webp", 350.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand5/AromaBliss Diffuser.webp", 290.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand5/CalmWave Candle.webp", 170.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand5/Balance Bottle.webp", 210.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand5/Focus Journal.webp", 150.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand5/Serenity Pillow Spray.jpg", 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand6/AeroTrack Smart Band.png", 540.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand6/bowflex-dumbbells.jpg", 720.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand6/PulsePro Chest Strap.webp", 210.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand6/AeroMat Trainer.webp", 250.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand6/HydraFuel Bottle.jfif", 170.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand6/TrainLite Shorts.jpg", 260.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand7/EcoGlow Lamp.webp", 250.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand7/GreenWave Blanket.jfif", 320.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand7/PlantPure Planter Set.jpg", 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand7/EcoFresh Diffuser.webp", 210.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand7/PureBreeze Air Filter.webp", 640.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand7/Harmony Coasters.jfif", 160.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand8/VoltSync Charger.webp", 280.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand8/StreamPad Mouse.jpg", 240.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand8/DataShell SSD Case.jpg", 190.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand8/WavePods Mini.jpg", 420.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand8/NeonLink Cable Set.webp", 160.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand8/GlideStand Laptop Dock.jpg", 360.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand9/AquaRenew Cleanser.png", 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand9/BrightVeil Moisturizer.png", 220.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand9/PureCure Mask.jpg", 240.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand9/GlowHydra Serum.webp", 390.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand9/VitaLush Night Cream.webp", 260.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand9/FreshTone Toner.webp", 210.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand10/VelvetEdge Dress.webp", 780.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand10/UrbanGleam Jacket.jfif", 650.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand10/ChromaSneak Shoes.webp", 540.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand10/LuxeLine Handbag.jfif", 720.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand10/PulseFit Crop Top.webp", 190.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "Products/Brand10/NeoAura Sunglasses.jfif", 350.00m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/novawear_tshirt.jpg", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/novawear_jacket.jpg", 79.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/novawear_sneakers.jpg", 89.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/novawear_hoodie.jpg", 59.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/novawear_tote.jpg", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/novawear_pants.jpg", 54.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/techease_cable.jpg", 14.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/techease_dock.jpg", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/techease_earbuds.jpg", 89.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/techease_mount.jpg", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/techease_watch.jpg", 129.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/techease_case.jpg", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/glowify_serum.jpg", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/glowify_cleanser.jpg", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/glowify_toner.jpg", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/glowify_nightcream.jpg", 44.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/glowify_sunscreen.jpg", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/glowify_moisturizer.jpg", 34.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/urbanfuel_hoodie.jpg", 64.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/urbanfuel_joggers.jpg", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/urbanfuel_sneakers.jpg", 89.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/urbanfuel_jacket.jpg", 99.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/urbanfuel_cap.jpg", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/urbanfuel_tee.jpg", 34.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/zenora_mat.jpg", 59.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/zenora_diffuser.jpg", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/zenora_candle.jpg", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/zenora_bottle.jpg", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/zenora_journal.jpg", 14.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/zenora_spray.jpg", 17.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/aerofit_band.jpg", 79.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/aerofit_dumbbells.jpg", 129.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/aerofit_strap.jpg", 59.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/aerofit_mat.jpg", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/aerofit_bottle.jpg", 34.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/aerofit_shorts.jpg", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/econest_lamp.jpg", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/econest_blanket.jpg", 59.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/econest_planters.jpg", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/econest_diffuser.jpg", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/econest_filter.jpg", 99.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/econest_coasters.jpg", 14.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/bytewave_charger.jpg", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/bytewave_mouse.jpg", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/bytewave_ssdcase.jpg", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/bytewave_earbuds.jpg", 59.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/bytewave_cables.jpg", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/bytewave_stand.jpg", 44.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/pureglow_cleanser.jpg", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/pureglow_moisturizer.jpg", 34.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/pureglow_mask.jpg", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/pureglow_serum.jpg", 44.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/pureglow_nightcream.jpg", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/pureglow_toner.jpg", 22.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/trendora_dress.jpg", 89.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/trendora_jacket.jpg", 119.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/trendora_sneakers.jpg", 99.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/trendora_bag.jpg", 149.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/trendora_croptop.jpg", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "MediaUrl", "Price" },
                values: new object[] { "https://example.com/media/trendora_sunglasses.jpg", 59.99m });
        }
    }
}
