using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding
{
    public class ReelSeeding : IEntityTypeConfiguration<Reel>
    {
        public void Configure(EntityTypeBuilder<Reel> builder)
        {
            builder.HasData([
                // -------------------- Brand 1: NovaWear – Sustainable fashion --------------------
                new Reel { Id=1, BrandId=1, ProductId=1, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=1200, NumOfWatches=8000 },
                new Reel { Id=2, BrandId=1, ProductId=2, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2300, NumOfWatches=15000 },
                new Reel { Id=3, BrandId=1, ProductId=3, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link",CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=1800, NumOfWatches=11000 },
                new Reel { Id=4, BrandId=1, ProductId=4, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link",CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2600, NumOfWatches=20000 },
                new Reel { Id=5, BrandId=1, ProductId=5, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link",CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=3400, NumOfWatches=25000 },
                
                // -------------------- Brand 2: TechEase – Smart accessories --------------------
               new Reel { Id=6, BrandId=2, ProductId=7, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),NumOfLikes=800, NumOfWatches=5000 },
               new Reel { Id=7, BrandId=2, ProductId=8, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),NumOfLikes=6000, NumOfWatches=95000 },
               new Reel { Id=8, BrandId=2, ProductId=9, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=9000, NumOfWatches=30000 },
               new Reel { Id=9, BrandId=2, ProductId=10, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link",CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=15000, NumOfWatches=35000 },
               new Reel { Id=10,BrandId=2, ProductId=11, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link",CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=100000, NumOfWatches=300000 },

                // -------------------- Brand 3: Glowify – Natural skincare --------------------
                new Reel { Id=11, BrandId=3, ProductId=13, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2000, NumOfWatches=10000 },
                new Reel { Id=12, BrandId=3, ProductId=14, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=5000, NumOfWatches=20000 },
                new Reel { Id=13, BrandId=3, ProductId=15, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=8000, NumOfWatches=25000 },
                new Reel { Id=14, BrandId=3, ProductId=16, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=10000, NumOfWatches=40000 },
                new Reel { Id=15, BrandId=3, ProductId=17, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=15000, NumOfWatches=50000 },

                // -------------------- Brand 4: UrbanFuel – Premium streetwear --------------------
                new Reel { Id=16, BrandId=4, ProductId=19, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=1700, NumOfWatches=12000 },
                new Reel { Id=17, BrandId=4, ProductId=20, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2500, NumOfWatches=18000 },
                new Reel { Id=18, BrandId=4, ProductId=21, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=4000, NumOfWatches=23000 },
                new Reel { Id=19, BrandId=4, ProductId=22, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=5200, NumOfWatches=30000 },
                new Reel { Id=20, BrandId=4, ProductId=23, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=7500, NumOfWatches=35000 },

                // -------------------- Brand 5: Zenora – Wellness lifestyle --------------------
                new Reel { Id=21, BrandId=5, ProductId=25, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=1300, NumOfWatches=10000 },
                new Reel { Id=22, BrandId=5, ProductId=26, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2000, NumOfWatches=14000 },
                new Reel { Id=23, BrandId=5, ProductId=27, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=3600, NumOfWatches=20000 },
                new Reel { Id=24, BrandId=5, ProductId=28, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=4500, NumOfWatches=26000 },
                new Reel { Id=25, BrandId=5, ProductId=29, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=6000, NumOfWatches=30000 },

                 // -------------------- Brand 6: AeroFit – Smart fitness gear --------------------
                new Reel { Id=26, BrandId=6, ProductId=31, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=1800, NumOfWatches=9000 },
                new Reel { Id=27, BrandId=6, ProductId=32, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2200, NumOfWatches=15000 },
                new Reel { Id=28, BrandId=6, ProductId=33, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=3500, NumOfWatches=22000 },
                new Reel { Id=29, BrandId=6, ProductId=34, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=4800, NumOfWatches=28000 },
                new Reel { Id=30, BrandId=6, ProductId=35, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=5200, NumOfWatches=31000 },

                 // -------------------- Brand 7: EcoNest – Eco-friendly home solutions --------------------
                 new Reel { Id=31, BrandId=7, ProductId=37, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=1500, NumOfWatches=7000 },
                 new Reel { Id=32, BrandId=7, ProductId=38, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2100, NumOfWatches=13000 },
                 new Reel { Id=33, BrandId=7, ProductId=39, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=2700, NumOfWatches=20000 },
                 new Reel { Id=34, BrandId=7, ProductId=40, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=4000, NumOfWatches=26000 },
                 new Reel { Id=35, BrandId=7, ProductId=41, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=5200, NumOfWatches=32000 },

                 // -------------------- Brand 8: ByteWave – Tech-driven accessories --------------------
                 new Reel { Id=36, BrandId=8, ProductId=43, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=1800, NumOfWatches=11000 },
                 new Reel { Id=37, BrandId=8, ProductId=44, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2500, NumOfWatches=16000 },
                 new Reel { Id=38, BrandId=8, ProductId=45, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=3900, NumOfWatches=22000 },
                 new Reel { Id=39, BrandId=8, ProductId=46, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=4800, NumOfWatches=27000 },
                 new Reel { Id=40, BrandId=8, ProductId=47, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=6500, NumOfWatches=33000 },


                  // -------------------- Brand 9: PureGlow – Clean & ethical skincare --------------------
                  new Reel { Id=41, BrandId=9, ProductId=49, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=1200, NumOfWatches=8000 },
                  new Reel { Id=42, BrandId=9, ProductId=50, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2000, NumOfWatches=12000 },
                  new Reel { Id=43, BrandId=9, ProductId=51, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=2700, NumOfWatches=18000 },
                  new Reel { Id=44, BrandId=9, ProductId=52, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=3600, NumOfWatches=25000 },
                  new Reel { Id=45, BrandId=9, ProductId=53, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=4900, NumOfWatches=30000 },

                   // -------------------- Brand 10: Trendora – Curated fashion for trendsetters --------------------
                   new Reel { Id=46, BrandId=10, ProductId=55, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=1500, NumOfWatches=7000 },
                   new Reel { Id=47, BrandId=10, ProductId=56, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), NumOfLikes=2200, NumOfWatches=14000 },
                   new Reel { Id=48, BrandId=10, ProductId=57, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=3000, NumOfWatches=20000 },
                   new Reel { Id=49, BrandId=10, ProductId=58, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=4200, NumOfWatches=25000 },
                   new Reel { Id=50, BrandId=10, ProductId=59, VideoUrl="https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link", CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),  NumOfLikes=5100, NumOfWatches=32000 },



            ]);


        }
    }
}
