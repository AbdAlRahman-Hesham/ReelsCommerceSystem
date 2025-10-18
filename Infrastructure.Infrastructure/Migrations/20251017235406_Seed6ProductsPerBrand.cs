using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seed6ProductsPerBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Category", "CreatedAt", "Description", "DiscountPercentage", "IsCustomizable", "MediaUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "Clothing", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathable organic cotton tee for everyday comfort.", 10m, false, "https://example.com/media/novawear_tshirt.jpg", "EcoFlex T-Shirt", 29.99m, 120 },
                    { 2, 1, "Clothing", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stylish recycled denim jacket for a sustainable look.", 20m, true, "https://example.com/media/novawear_jacket.jpg", "ReVibe Denim Jacket", 79.99m, 80 },
                    { 3, 1, "Footwear", new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight sneakers made from recycled fibers.", 30m, false, "https://example.com/media/novawear_sneakers.jpg", "EcoStride Sneakers", 89.99m, 150 },
                    { 4, 1, "Clothing", new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soft hoodie crafted from sustainable bamboo fabric.", 40m, true, "https://example.com/media/novawear_hoodie.jpg", "Bamboo Breeze Hoodie", 59.99m, 100 },
                    { 5, 1, "Accessories", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eco-friendly tote bag with minimalist design.", null, false, "https://example.com/media/novawear_tote.jpg", "ReLeaf Tote Bag", 19.99m, 200 },
                    { 6, 1, "Clothing", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable pants made from recycled polyester.", null, false, "https://example.com/media/novawear_pants.jpg", "NatureFlow Pants", 54.99m, 90 },
                    { 7, 2, "Electronics", new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast-charging braided USB-C cable with smart chip.", 10m, false, "https://example.com/media/techease_cable.jpg", "SyncCharge Cable", 14.99m, 300 },
                    { 8, 2, "Electronics", new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Multi-device charging dock with wireless pad.", 20m, false, "https://example.com/media/techease_dock.jpg", "SmartDock Pro", 49.99m, 120 },
                    { 9, 2, "Audio", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noise-cancelling Bluetooth earbuds with 24h battery.", 30m, false, "https://example.com/media/techease_earbuds.jpg", "AirPulse Earbuds", 89.99m, 200 },
                    { 10, 2, "Accessories", new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smart magnetic car mount with auto-lock system.", 40m, false, "https://example.com/media/techease_mount.jpg", "MagGrip Phone Mount", 24.99m, 150 },
                    { 11, 2, "Wearables", new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fitness smartwatch with heart-rate and sleep tracking.", null, false, "https://example.com/media/techease_watch.jpg", "PulseTrack Watch", 129.99m, 80 },
                    { 12, 2, "Accessories", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "MagSafe-compatible slim phone case.", null, false, "https://example.com/media/techease_case.jpg", "GlideCase", 19.99m, 180 },
                    { 13, 3, "Skincare", new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitamin C serum that brightens and smooths skin.", 10m, false, "https://example.com/media/glowify_serum.jpg", "HydraBloom Serum", 39.99m, 120 },
                    { 14, 3, "Skincare", new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gentle cleanser with aloe and green tea.", 20m, false, "https://example.com/media/glowify_cleanser.jpg", "PureDew Cleanser", 19.99m, 200 },
                    { 15, 3, "Skincare", new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hydrating toner that refines pores naturally.", 30m, false, "https://example.com/media/glowify_toner.jpg", "LumiMist Toner", 24.99m, 150 },
                    { 16, 3, "Skincare", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rich moisturizer for overnight skin repair.", 40m, false, "https://example.com/media/glowify_nightcream.jpg", "Radiant Night Cream", 44.99m, 100 },
                    { 17, 3, "Skincare", new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPF 50 mineral sunscreen with lightweight feel.", null, false, "https://example.com/media/glowify_sunscreen.jpg", "GlowShield Sunscreen", 29.99m, 180 },
                    { 18, 3, "Skincare", new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "All-day hydration for sensitive skin.", null, false, "https://example.com/media/glowify_moisturizer.jpg", "SilkTouch Moisturizer", 34.99m, 160 },
                    { 19, 4, "Clothing", new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oversized hoodie with minimalist street-style logo.", 10m, false, "https://example.com/media/urbanfuel_hoodie.jpg", "StreetCore Hoodie", 64.99m, 120 },
                    { 20, 4, "Clothing", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slim-fit joggers for comfort and performance.", 20m, false, "https://example.com/media/urbanfuel_joggers.jpg", "UrbanFlex Joggers", 49.99m, 100 },
                    { 21, 4, "Footwear", new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern street sneakers with breathable mesh upper.", 30m, false, "https://example.com/media/urbanfuel_sneakers.jpg", "FuelRunner Sneakers", 89.99m, 150 },
                    { 22, 4, "Outerwear", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight windbreaker with waterproof coating.", 40m, false, "https://example.com/media/urbanfuel_jacket.jpg", "CityWave Jacket", 99.99m, 80 },
                    { 23, 4, "Accessories", new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic snapback cap with embroidered logo.", null, false, "https://example.com/media/urbanfuel_cap.jpg", "SnapEdge Cap", 24.99m, 200 },
                    { 24, 4, "Clothing", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soft cotton tee with subtle reflective branding.", null, false, "https://example.com/media/urbanfuel_tee.jpg", "MetroLayer Tee", 34.99m, 140 },
                    { 25, 5, "Fitness", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium non-slip yoga mat made with eco rubber.", 10m, false, "https://example.com/media/zenora_mat.jpg", "ZenMat Pro", 59.99m, 110 },
                    { 26, 5, "Wellness", new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultrasonic diffuser with ambient lighting.", 20m, false, "https://example.com/media/zenora_diffuser.jpg", "AromaBliss Diffuser", 39.99m, 150 },
                    { 27, 5, "Home", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soy candle infused with lavender and chamomile.", 30m, false, "https://example.com/media/zenora_candle.jpg", "CalmWave Candle", 19.99m, 180 },
                    { 28, 5, "Wellness", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Glass water bottle with bamboo lid and sleeve.", 40m, false, "https://example.com/media/zenora_bottle.jpg", "Balance Bottle", 24.99m, 160 },
                    { 29, 5, "Stationery", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided journal for mindfulness and productivity.", null, false, "https://example.com/media/zenora_journal.jpg", "Focus Journal", 14.99m, 200 },
                    { 30, 5, "Wellness", new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natural lavender mist for better sleep.", null, false, "https://example.com/media/zenora_spray.jpg", "Serenity Pillow Spray", 17.99m, 180 },
                    { 31, 6, "Wearables", new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fitness tracker with pulse and oxygen monitoring.", 10m, false, "https://example.com/media/aerofit_band.jpg", "AeroTrack Smart Band", 79.99m, 130 },
                    { 32, 6, "Equipment", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adjustable dumbbells for home strength training.", 20m, false, "https://example.com/media/aerofit_dumbbells.jpg", "FlexCore Dumbbells", 129.99m, 90 },
                    { 33, 6, "Accessories", new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heart-rate strap compatible with popular apps.", 30m, false, "https://example.com/media/aerofit_strap.jpg", "PulsePro Chest Strap", 59.99m, 100 },
                    { 34, 6, "Fitness", new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-density mat ideal for HIIT and yoga.", 40m, false, "https://example.com/media/aerofit_mat.jpg", "AeroMat Trainer", 39.99m, 140 },
                    { 35, 6, "Accessories", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smart bottle that tracks hydration levels.", null, false, "https://example.com/media/aerofit_bottle.jpg", "HydraFuel Bottle", 34.99m, 160 },
                    { 36, 6, "Apparel", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight shorts with moisture-wicking tech.", null, false, "https://example.com/media/aerofit_shorts.jpg", "TrainLite Shorts", 29.99m, 200 },
                    { 37, 7, "Home Decor", new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bamboo desk lamp with rechargeable LED bulb.", 10m, false, "https://example.com/media/econest_lamp.jpg", "EcoGlow Lamp", 49.99m, 110 },
                    { 38, 7, "Home", new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soft throw blanket made from recycled cotton.", 20m, false, "https://example.com/media/econest_blanket.jpg", "GreenWave Blanket", 59.99m, 100 },
                    { 39, 7, "Gardening", new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biodegradable planters perfect for indoor herbs.", 30m, false, "https://example.com/media/econest_planters.jpg", "PlantPure Planter Set", 29.99m, 180 },
                    { 40, 7, "Home Fragrance", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natural reed diffuser with citrus essential oils.", 40m, false, "https://example.com/media/econest_diffuser.jpg", "EcoFresh Diffuser", 24.99m, 150 },
                    { 41, 7, "Appliances", new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reusable air filter system for cleaner home air.", null, false, "https://example.com/media/econest_filter.jpg", "PureBreeze Air Filter", 99.99m, 90 },
                    { 42, 7, "Home Accessories", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cork coasters made from renewable materials.", null, false, "https://example.com/media/econest_coasters.jpg", "Harmony Coasters", 14.99m, 200 },
                    { 43, 8, "Electronics", new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-speed GaN charger with dual USB-C output.", 10m, false, "https://example.com/media/bytewave_charger.jpg", "VoltSync Charger", 39.99m, 150 },
                    { 44, 8, "Accessories", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic wireless mouse with silent clicks.", 20m, false, "https://example.com/media/bytewave_mouse.jpg", "StreamPad Mouse", 29.99m, 180 },
                    { 45, 8, "Storage", new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shockproof case for portable SSDs.", 30m, false, "https://example.com/media/bytewave_ssdcase.jpg", "DataShell SSD Case", 19.99m, 220 },
                    { 46, 8, "Audio", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compact true wireless earbuds with clear audio.", 40m, false, "https://example.com/media/bytewave_earbuds.jpg", "WavePods Mini", 59.99m, 140 },
                    { 47, 8, "Accessories", new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Color-coded USB-C and Lightning cable pack.", null, false, "https://example.com/media/bytewave_cables.jpg", "NeonLink Cable Set", 24.99m, 200 },
                    { 48, 8, "Office", new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foldable aluminum laptop stand with cooling vents.", null, false, "https://example.com/media/bytewave_stand.jpg", "GlideStand Laptop Dock", 44.99m, 130 },
                    { 49, 9, "Skincare", new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refreshing foaming cleanser for daily use.", 10m, false, "https://example.com/media/pureglow_cleanser.jpg", "AquaRenew Cleanser", 24.99m, 160 },
                    { 50, 9, "Skincare", new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight daily cream with niacinamide for radiant skin.", 20m, false, "https://example.com/media/pureglow_moisturizer.jpg", "BrightVeil Moisturizer", 34.99m, 140 },
                    { 51, 9, "Skincare", new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Detoxifying clay mask that purifies pores naturally.", 30m, false, "https://example.com/media/pureglow_mask.jpg", "PureCure Mask", 29.99m, 150 },
                    { 52, 9, "Skincare", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deep hydration serum enriched with hyaluronic acid.", 40m, false, "https://example.com/media/pureglow_serum.jpg", "GlowHydra Serum", 44.99m, 130 },
                    { 53, 9, "Skincare", new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nourishing night cream with plant-based peptides.", null, false, "https://example.com/media/pureglow_nightcream.jpg", "VitaLush Night Cream", 39.99m, 120 },
                    { 54, 9, "Skincare", new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balancing toner that smooths skin and reduces shine.", null, false, "https://example.com/media/pureglow_toner.jpg", "FreshTone Toner", 22.99m, 160 },
                    { 55, 10, "Clothing", new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chic velvet dress perfect for evening occasions.", 10m, false, "https://example.com/media/trendora_dress.jpg", "VelvetEdge Dress", 89.99m, 90 },
                    { 56, 10, "Outerwear", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Metallic cropped jacket for a bold statement look.", 20m, false, "https://example.com/media/trendora_jacket.jpg", "UrbanGleam Jacket", 119.99m, 80 },
                    { 57, 10, "Footwear", new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Color-shifting sneakers that stand out everywhere.", 30m, false, "https://example.com/media/trendora_sneakers.jpg", "ChromaSneak Shoes", 99.99m, 120 },
                    { 58, 10, "Accessories", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant faux-leather handbag with gold accents.", 40m, false, "https://example.com/media/trendora_bag.jpg", "LuxeLine Handbag", 149.99m, 70 },
                    { 59, 10, "Clothing", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trendy cropped top for modern streetwear style.", null, false, "https://example.com/media/trendora_croptop.jpg", "PulseFit Crop Top", 39.99m, 150 },
                    { 60, 10, "Accessories", new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Retro-futuristic shades with UV400 protection.", null, false, "https://example.com/media/trendora_sunglasses.jpg", "NeoAura Sunglasses", 59.99m, 200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);
        }
    }
}
