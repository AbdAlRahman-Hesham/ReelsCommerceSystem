using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding
{
    public class ProductImageSeeding : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            var baseUrl = @"Products/";
            builder.HasData(new ProductImage[]
            {
            // ---------------- Brand 1 ----------------
            new ProductImage { Id = 1, ProductId = 1, Url = baseUrl + "Brand1/EcoFlex T-Shirt.png" },
            new ProductImage { Id = 2, ProductId = 2, Url = baseUrl + "Brand1/ReVibe Denim Jacket.jfif" },
            new ProductImage { Id = 3, ProductId = 3, Url = baseUrl + "Brand1/EcoStride Sneakers.jfif" },
            new ProductImage { Id = 4, ProductId = 4, Url = baseUrl + "Brand1/Bamboo Breeze Hoodie.png" },
            new ProductImage { Id = 5, ProductId = 5, Url = baseUrl + "Brand1/ReLeaf Tote Bag.jfif" },
            new ProductImage { Id = 6, ProductId = 6, Url = baseUrl + "Brand1/NatureFlow Pants.webp" },

            // ---------------- Brand 2 ----------------
            new ProductImage { Id = 7, ProductId = 7, Url = baseUrl + "Brand2/SyncCharge Cable.jfif" },
            new ProductImage { Id = 8, ProductId = 8, Url = baseUrl + "Brand2/SmartDock Pro.jfif" },
            new ProductImage { Id = 9, ProductId = 9, Url = baseUrl + "Brand2/AirPulse Earbuds.jfif" },
            new ProductImage { Id = 10, ProductId = 10, Url = baseUrl + "Brand2/MagGrip Phone Mount.jfif" },
            new ProductImage { Id = 11, ProductId = 11, Url = baseUrl + "Brand2/PulseTrack Watch.jfif" },
            new ProductImage { Id = 12, ProductId = 12, Url = baseUrl + "Brand2/GlideCase.jfif" },

            // ---------------- Brand 3 ----------------
            new ProductImage { Id = 13, ProductId = 13, Url = baseUrl + "Brand3/HydraBloom Serum.jpg" },
            new ProductImage { Id = 14, ProductId = 14, Url = baseUrl + "Brand3/PureDew Cleanser.png" },
            new ProductImage { Id = 15, ProductId = 15, Url = baseUrl + "Brand3/LumiMist Toner.webp" },
            new ProductImage { Id = 16, ProductId = 16, Url = baseUrl + "Brand3/Radiant Night Cream.webp" },
            new ProductImage { Id = 17, ProductId = 17, Url = baseUrl + "Brand3/GlowShield Sunscreen.jpg" },
            new ProductImage { Id = 18, ProductId = 18, Url = baseUrl + "Brand3/SilkTouch Moisturizer.png" },

            // ---------------- Brand 4 ----------------
            new ProductImage { Id = 19, ProductId = 19, Url = baseUrl + "Brand4/StreetCore Hoodie.png" },
            new ProductImage { Id = 20, ProductId = 20, Url = baseUrl + "Brand4/UrbanFlex Joggers.png" },
            new ProductImage { Id = 21, ProductId = 21, Url = baseUrl + "Brand4/FuelRunner Sneakers.png" },
            new ProductImage { Id = 22, ProductId = 22, Url = baseUrl + "Brand4/CityWave Jacket.png" },
            new ProductImage { Id = 23, ProductId = 23, Url = baseUrl + "Brand4/SnapEdge Cap.webp" },
            new ProductImage { Id = 24, ProductId = 24, Url = baseUrl + "Brand4/MetroLayer Tee.jpg" },

            // ---------------- Brand 5 ----------------
            new ProductImage { Id = 25, ProductId = 25, Url = baseUrl + "Brand5/ZenMat.webp" },
            new ProductImage { Id = 26, ProductId = 26, Url = baseUrl + "Brand5/AromaBliss Diffuser.webp" },
            new ProductImage { Id = 27, ProductId = 27, Url = baseUrl + "Brand5/CalmWave Candle.webp" },
            new ProductImage { Id = 28, ProductId = 28, Url = baseUrl + "Brand5/Balance Bottle.webp" },
            new ProductImage { Id = 29, ProductId = 29, Url = baseUrl + "Brand5/Focus Journal.webp" },
            new ProductImage { Id = 30, ProductId = 30, Url = baseUrl + "Brand5/Serenity Pillow Spray.jpg" },
            // ---------------- Brand 6 ----------------
new ProductImage { Id = 31, ProductId = 31, Url = baseUrl + "Brand6/AeroTrack Smart Band.png" },
new ProductImage { Id = 32, ProductId = 32, Url = baseUrl + "Brand6/bowflex-dumbbells.jpg" },
new ProductImage { Id = 33, ProductId = 33, Url = baseUrl + "Brand6/PulsePro Chest Strap.webp" },
new ProductImage { Id = 34, ProductId = 34, Url = baseUrl + "Brand6/AeroMat Trainer.webp" },
new ProductImage { Id = 35, ProductId = 35, Url = baseUrl + "Brand6/HydraFuel Bottle.jfif" },
new ProductImage { Id = 36, ProductId = 36, Url = baseUrl + "Brand6/TrainLite Shorts.jpg" },

// ---------------- Brand 7 ----------------
new ProductImage { Id = 37, ProductId = 37, Url = baseUrl + "Brand7/EcoGlow Lamp.webp" },
new ProductImage { Id = 38, ProductId = 38, Url = baseUrl + "Brand7/GreenWave Blanket.jfif" },
new ProductImage { Id = 39, ProductId = 39, Url = baseUrl + "Brand7/PlantPure Planter Set.jpg" },
new ProductImage { Id = 40, ProductId = 40, Url = baseUrl + "Brand7/EcoFresh Diffuser.webp" },
new ProductImage { Id = 41, ProductId = 41, Url = baseUrl + "Brand7/PureBreeze Air Filter.webp" },
new ProductImage { Id = 42, ProductId = 42, Url = baseUrl + "Brand7/Harmony Coasters.jfif" },

// ---------------- Brand 8 ----------------
new ProductImage { Id = 43, ProductId = 43, Url = baseUrl + "Brand8/VoltSync Charger.webp" },
new ProductImage { Id = 44, ProductId = 44, Url = baseUrl + "Brand8/StreamPad Mouse.jpg" },
new ProductImage { Id = 45, ProductId = 45, Url = baseUrl + "Brand8/DataShell SSD Case.jpg" },
new ProductImage { Id = 46, ProductId = 46, Url = baseUrl + "Brand8/WavePods Mini.jpg" },
new ProductImage { Id = 47, ProductId = 47, Url = baseUrl + "Brand8/NeonLink Cable Set.webp" },
new ProductImage { Id = 48, ProductId = 48, Url = baseUrl + "Brand8/GlideStand Laptop Dock.jpg" },

// ---------------- Brand 9 ----------------
new ProductImage { Id = 49, ProductId = 49, Url = baseUrl + "Brand9/AquaRenew Cleanser.png" },
new ProductImage { Id = 50, ProductId = 50, Url = baseUrl + "Brand9/BrightVeil Moisturizer.png" },
new ProductImage { Id = 51, ProductId = 51, Url = baseUrl + "Brand9/PureCure Mask.jpg" },
new ProductImage { Id = 52, ProductId = 52, Url = baseUrl + "Brand9/GlowHydra Serum.webp" },
new ProductImage { Id = 53, ProductId = 53, Url = baseUrl + "Brand9/VitaLush Night Cream.webp" },
new ProductImage { Id = 54, ProductId = 54, Url = baseUrl + "Brand9/FreshTone Toner.webp" },

// ---------------- Brand 10 ----------------
new ProductImage { Id = 55, ProductId = 55, Url = baseUrl + "Brand10/VelvetEdge Dress.webp" },
new ProductImage { Id = 56, ProductId = 56, Url = baseUrl + "Brand10/UrbanGleam Jacket.jfif" },
new ProductImage { Id = 57, ProductId = 57, Url = baseUrl + "Brand10/ChromaSneak Shoes.webp" },
new ProductImage { Id = 58, ProductId = 58, Url = baseUrl + "Brand10/LuxeLine Handbag.jfif" },
new ProductImage { Id = 59, ProductId = 59, Url = baseUrl + "Brand10/PulseFit Crop Top.webp" },
new ProductImage { Id = 60, ProductId = 60, Url = baseUrl + "Brand10/NeoAura Sunglasses.jfif" },
            });
        }
    }
}
