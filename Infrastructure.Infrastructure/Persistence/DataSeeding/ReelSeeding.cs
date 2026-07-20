using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ReelSeeding : IEntityTypeConfiguration<Reel>
{
    public void Configure(EntityTypeBuilder<Reel> builder)
    {
        IReadOnlyList<string> reels = new List<string>()
        {
            "https://res.cloudinary.com/dppwxudes/video/upload/v1764716212/Work_jacket_gitu_mulu_designnya_thanks_to_rhodes.apparel_kali_ini_level_up_design_Work_Jacke_p1asve.mp4",
            "https://res.cloudinary.com/dppwxudes/video/upload/v1764716081/Elevated_basic_outfitideas_for_this_summer_All_items_from_Vietnamese_local_brand_laminapparel_nqtgbk.mp4",
            "https://res.cloudinary.com/dppwxudes/video/upload/v1764716068/%EF%B8%8F__BRANDS_MENTIONED_IN_ORDER_stpsco_-_cielodenim_-_frencheethelabel_......_localbrand_fas_khlqmj.mp4",
            "https://res.cloudinary.com/dppwxudes/video/upload/v1764716062/Off-shoulder_sweater_Colors-_white_-_black_-_gray_-_beige_-_red-_brown_-_Olive_-_brgandy_-_Nav_kdiud7.mp4",
            "https://res.cloudinary.com/dppwxudes/video/upload/v1764716042/Original_Brand_Vietnam_local_brand_is_open_for_preorder_%E1%9E%94%E1%9E%BE%E1%9E%80%E1%9E%80%E1%9E%98%E1%9F%92%E1%9E%98%E1%9E%84%E1%9F%8B%E1%9E%85%E1%9E%B6%E1%9E%94%E1%9F%8B%E1%9E%96%E1%9E%B8%E1%9E%90%E1%9F%92%E1%9E%84%E1%9F%83_18_22_Ju_tv9j0y.mp4",
            "https://res.cloudinary.com/dppwxudes/video/upload/v1764716010/Pullover_%EF%B8%8FColors-_burgundy_-_navy_-_beigeMaterial-_eajinahSize-_One_size_Price-_explorepage_i_umxux6.mp4"
        };
        int i = 0;
        DateTime _dateTime = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        builder.HasData([
    // -------------------- Brand 1: NovaWear – Sustainable fashion --------------------
    new Reel { Id=1, BrandId=1, Title="Sustainable Winter Look", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=2, BrandId=1, Title="Eco-Friendly Street Style", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=3, BrandId=1, Title="Minimalist Outfit Inspo", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=4, BrandId=1, Title="Recycled Fabric Jacket Drop", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=5, BrandId=1, Title="Sustainable Fashion Trends", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },

    // -------------------- Brand 2: TechEase – Smart accessories --------------------
    new Reel { Id=6, BrandId=2, Title="Smart Watch Unboxing", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=7, BrandId=2, Title="Top 5 Tech Accessories 2024", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=8, BrandId=2, Title="Wearable Tech Review", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=9, BrandId=2, Title="Daily Tech Essentials", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=10, BrandId=2, Title="Smart Gear for Work", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },

    // -------------------- Brand 3: Glowify – Natural skincare --------------------
    new Reel { Id=11, BrandId=3, Title="Morning Skincare Routine", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=12, BrandId=3, Title="Glow Serum Review", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=13, BrandId=3, Title="Natural Skincare Unboxing", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=14, BrandId=3, Title="Clean Beauty Explained", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=15, BrandId=3, Title="Healthy Skin Tips", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },

    // -------------------- Brand 4: UrbanFuel – Premium streetwear --------------------
    new Reel { Id=16, BrandId=4, Title="Streetwear Hoodie Drop", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=17, BrandId=4, Title="Urban Style Lookbook", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=18, BrandId=4, Title="Street Fashion Essentials", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=19, BrandId=4, Title="Premium Street Gear", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=20, BrandId=4, Title="Winter Streetwear Outfit", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },

    // -------------------- Brand 5: Zenora – Wellness lifestyle --------------------
    new Reel { Id=21, BrandId=5, Title="Morning Wellness Routine", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=22, BrandId=5, Title="Relaxing Home Setup", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=23, BrandId=5, Title="Self-Care Essentials", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=24, BrandId=5, Title="Mindfulness Lifestyle", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=25, BrandId=5, Title="Zen-Inspired Living", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },

    // -------------------- Brand 6: AeroFit – Smart fitness gear --------------------
    new Reel { Id=26, BrandId=6, Title="Smart Fitness Tracker", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=27, BrandId=6, Title="Workout Gear Review", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=28, BrandId=6, Title="Gym Essentials 2024", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=29, BrandId=6, Title="Daily Training Motivation", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=30, BrandId=6, Title="Fitness Smartwear Guide", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },

    // -------------------- Brand 7: EcoNest – Eco-friendly home solutions --------------------
    new Reel { Id=31, BrandId=7, Title="Eco Home Makeover", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=32, BrandId=7, Title="Sustainable Living Tips", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=33, BrandId=7, Title="Eco-Friendly Home Decor", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=34, BrandId=7, Title="Green Home Essentials", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=35, BrandId=7, Title="Zero Waste Lifestyle", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },

    // -------------------- Brand 8: ByteWave – Tech-driven accessories --------------------
    new Reel { Id=36, BrandId=8, Title="Gadget of the Week", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=37, BrandId=8, Title="Top Travel Tech", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=38, BrandId=8, Title="Portable Tech Must-Haves", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=39, BrandId=8, Title="Smart Device Showcase", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=40, BrandId=8, Title="Best Tech Accessories", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },

    // -------------------- Brand 9: PureGlow – Clean & ethical skincare --------------------
    new Reel { Id=41, BrandId=9, Title="Hydrating Skincare Routine", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=42, BrandId=9, Title="PureGlow Serum Review", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=43, BrandId=9, Title="Night Routine for Glowing Skin", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=44, BrandId=9, Title="Daily Clean Beauty Tips", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=45, BrandId=9, Title="Skincare for All Seasons", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },

    // -------------------- Brand 10: Trendora – Curated fashion for trendsetters --------------------
    new Reel { Id=46, BrandId=10, Title="Trendy Summer Outfits", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=47, BrandId=10, Title="New Season Fashion Drop", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=48, BrandId=10, Title="Style Inspiration Lookbook", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=49, BrandId=10, Title="Latest Fashion Trends", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
    new Reel { Id=50, BrandId=10, Title="Trendora Outfit Guide", VideoUrl=reels[i++ % reels.Count], CreatedAt=_dateTime, UpdatedAt=_dateTime },
]);



    }
}
