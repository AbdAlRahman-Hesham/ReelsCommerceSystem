using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Enums;


namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class ProductInformationSeeding : IEntityTypeConfiguration<ProductInformation>
{
    public void Configure(EntityTypeBuilder<ProductInformation> builder)
    {
        var productInfos = new List<ProductInformation>();
        int infoId = 1;

        // Helper method to add product information
        void AddInfo(int productId, string key, string value, InformationType type, string? arKey = null, string? arValue = null, string? group = null, string? arGroup = null, int order = 0)
        {
            productInfos.Add(new ProductInformation
            {
                Id = infoId++,
                ProductId = productId,
                Key = key,
                Value = value,
                ArKey = arKey,
                ArValue = arValue,
                Type = type,
                Group = group,
                ArGroup = arGroup,
                DisplayOrder = order,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            });
        }

        // -------------------- Brand 1: NovaWear – Sustainable fashion --------------------

        // Product 1: EcoFlex T-Shirt
        AddInfo(1, "Material", "100% Organic Cotton", InformationType.String,
            "المادة", "قطن عضوي 100%", "General", "عام", 1);
        AddInfo(1, "Weight", "150", InformationType.Number,
            "الوزن", "150", "Dimensions", "الأبعاد", 2);
        AddInfo(1, "Eco-Friendly", "true", InformationType.Boolean,
            "صديق للبيئة", "نعم", "Sustainability", "الاستدامة", 3);
        AddInfo(1, "Certifications", "GOTS Certified, Organic Content Standard", InformationType.String,
            "الشهادات", "معتمد GOTS، معيار المحتوى العضوي", "Sustainability", "الاستدامة", 4);
        AddInfo(1, "Care Instructions", "Machine wash cold, Tumble dry low", InformationType.String,
            "تعليمات العناية", "غسيل بالماكينة بماء بارد، تجفيف بالمجفف على حرارة منخفضة", "Care", "العناية", 5);

        // Product 2: ReVibe Denim Jacket
        AddInfo(2, "Material", "Recycled Denim (85% Cotton, 15% Polyester)", InformationType.String,
            "المادة", "دينيم معاد تدويره (85% قطن، 15% بوليستر)", "General", "عام", 1);
        AddInfo(2, "Weight", "800", InformationType.Number,
            "الوزن", "800", "Dimensions", "الأبعاد", 2);
        AddInfo(2, "Eco-Friendly", "true", InformationType.Boolean,
            "صديق للبيئة", "نعم", "Sustainability", "الاستدامة", 3);
        AddInfo(2, "Wash Care", "Dry clean only", InformationType.String,
            "العناية بالغسيل", "تنظيف جاف فقط", "Care", "العناية", 4);

        // Product 3: EcoStride Sneakers
        AddInfo(3, "Material", "Recycled PET, Rubber sole", InformationType.String,
            "المادة", "بولي إيثيلين تيريفثاليت معاد تدويره، نعل مطاطي", "General", "عام", 1);
        AddInfo(3, "Weight", "280", InformationType.Number,
            "الوزن", "280", "Dimensions", "الأبعاد", 2);
        AddInfo(3, "Water Resistant", "true", InformationType.Boolean,
            "مقاوم للماء", "نعم", "Features", "المميزات", 3);
        AddInfo(3, "Eco-Friendly", "true", InformationType.Boolean,
            "صديق للبيئة", "نعم", "Sustainability", "الاستدامة", 4);

        // -------------------- Brand 2: TechEase – Smart accessories --------------------

        // Product 7: SyncCharge Cable
        AddInfo(7, "Cable Length", "1.5", InformationType.Number,
            "طول الكابل", "1.5", "Specifications", "المواصفات", 1);
        AddInfo(7, "Fast Charging", "true", InformationType.Boolean,
            "شحن سريع", "نعم", "Features", "المميزات", 2);
        AddInfo(7, "Wattage", "100", InformationType.Number,
            "القدرة", "100", "Technical", "تقني", 3);
        AddInfo(7, "Warranty Period", "2", InformationType.Number,
            "فترة الضمان", "2", "Warranty", "الضمان", 4);

        // Product 9: AirPulse Earbuds
        AddInfo(9, "Battery Life", "24", InformationType.Number,
            "عمر البطارية", "24", "Battery", "البطارية", 1);
        AddInfo(9, "Noise Cancellation", "true", InformationType.Boolean,
            "إلغاء الضوضاء", "نعم", "Features", "المميزات", 2);
        AddInfo(9, "Waterproof", "true", InformationType.Boolean,
            "مقاوم للماء", "نعم", "Features", "المميزات", 3);
        AddInfo(9, "Bluetooth Version", "5.2", InformationType.String,
            "إصدار البلوتوث", "5.2", "Technical", "تقني", 4);

        // Product 11: PulseTrack Watch
        AddInfo(11, "Screen Size", "1.3", InformationType.Number,
            "حجم الشاشة", "1.3", "Display", "الشاشة", 1);
        AddInfo(11, "Heart Rate Monitor", "true", InformationType.Boolean,
            "مراقب معدل ضربات القلب", "نعم", "Health", "الصحة", 2);
        AddInfo(11, "Sleep Tracking", "true", InformationType.Boolean,
            "تتبع النوم", "نعم", "Health", "الصحة", 3);
        AddInfo(11, "Battery Life", "7", InformationType.Number,
            "عمر البطارية", "7", "Battery", "البطارية", 4);

        // -------------------- Brand 3: Glowify – Natural skincare --------------------

        // Product 13: HydraBloom Serum
        AddInfo(13, "Volume", "30", InformationType.Number,
            "الحجم", "30", "General", "عام", 1);
        AddInfo(13, "Vegan", "true", InformationType.Boolean,
            "نباتي", "نعم", "Ethical", "أخلاقي", 2);
        AddInfo(13, "Cruelty Free", "true", InformationType.Boolean,
            "خالي من القسوة", "نعم", "Ethical", "أخلاقي", 3);
        AddInfo(13, "Skin Type", "All skin types", InformationType.String,
            "نوع البشرة", "جميع أنواع البشرة", "Usage", "الاستخدام", 4);
        AddInfo(13, "Key Ingredients", "Vitamin C, Hyaluronic Acid", InformationType.String,
            "المكونات الرئيسية", "فيتامين سي، حمض الهيالورونيك", "Ingredients", "المكونات", 5);

        // Product 17: GlowShield Sunscreen
        AddInfo(17, "SPF", "50", InformationType.Number,
            "معامل الحماية", "50", "Protection", "الحماية", 1);
        AddInfo(17, "Volume", "50", InformationType.Number,
            "الحجم", "50", "General", "عام", 2);
        AddInfo(17, "Mineral Based", "true", InformationType.Boolean,
            "قائم على المعادن", "نعم", "Ingredients", "المكونات", 3);
        AddInfo(17, "Water Resistant", "true", InformationType.Boolean,
            "مقاوم للماء", "نعم", "Features", "المميزات", 4);

        // -------------------- Brand 4: UrbanFuel – Premium streetwear --------------------

        // Product 19: StreetCore Hoodie
        AddInfo(19, "Material", "Cotton Blend", InformationType.String,
            "المادة", "مزيج قطني", "General", "عام", 1);
        AddInfo(19, "Weight", "650", InformationType.Number,
            "الوزن", "650", "Dimensions", "الأبعاد", 2);
        AddInfo(19, "Style", "Oversized", InformationType.String,
            "النمط", "مقاس كبير", "General", "عام", 3);
        AddInfo(19, "Pocket Count", "2", InformationType.Number,
            "عدد الجيوب", "2", "Features", "المميزات", 4);

        // Product 21: FuelRunner Sneakers
        AddInfo(21, "Material", "Mesh, Synthetic Leather", InformationType.String,
            "المادة", "قماش شبكي، جلد صناعي", "General", "عام", 1);
        AddInfo(21, "Weight", "320", InformationType.Number,
            "الوزن", "320", "Dimensions", "الأبعاد", 2);
        AddInfo(21, "Breathable", "true", InformationType.Boolean,
            "منفس", "نعم", "Features", "المميزات", 3);
        AddInfo(21, "Closure Type", "Lace-up", InformationType.String,
            "نوع الإغلاق", "ربط بالرباط", "Features", "المميزات", 4);

        // -------------------- Brand 6: AeroFit – Smart fitness gear --------------------

        // Product 31: AeroTrack Smart Band
        AddInfo(31, "Screen Size", "1.2", InformationType.Number,
            "حجم الشاشة", "1.2", "Display", "الشاشة", 1);
        AddInfo(31, "Battery Life", "7", InformationType.Number,
            "عمر البطارية", "7", "Battery", "البطارية", 2);
        AddInfo(31, "Heart Rate Monitor", "true", InformationType.Boolean,
            "مراقب معدل ضربات القلب", "نعم", "Health", "الصحة", 3);
        AddInfo(31, "Waterproof", "true", InformationType.Boolean,
            "مقاوم للماء", "نعم", "Features", "المميزات", 4);

        // Product 32: FlexCore Dumbbells
        AddInfo(32, "Weight Range", "5-25", InformationType.String,
            "نطاق الوزن", "25-5", "Specifications", "المواصفات", 1);
        AddInfo(32, "Adjustable", "true", InformationType.Boolean,
            "قابل للتعديل", "نعم", "Features", "المميزات", 2);
        AddInfo(32, "Material", "Steel, Plastic", InformationType.String,
            "المادة", "حديد، بلاستيك", "General", "عام", 3);

        // -------------------- Brand 7: EcoNest – Eco-friendly home solutions --------------------

        // Product 37: EcoGlow Lamp
        AddInfo(37, "Material", "Bamboo", InformationType.String,
            "المادة", "خيزران", "General", "عام", 1);
        AddInfo(37, "Height", "35", InformationType.Number,
            "الارتفاع", "35", "Dimensions", "الأبعاد", 2);
        AddInfo(37, "Dimmable", "true", InformationType.Boolean,
            "قابل للتعتيم", "نعم", "Features", "المميزات", 3);
        AddInfo(37, "Eco-Friendly", "true", InformationType.Boolean,
            "صديق للبيئة", "نعم", "Sustainability", "الاستدامة", 4);

        // -------------------- Brand 8: ByteWave – Tech-driven accessories --------------------

        // Product 43: VoltSync Charger
        AddInfo(43, "Wattage", "65", InformationType.Number,
            "القدرة", "65", "Technical", "تقني", 1);
        AddInfo(43, "Ports", "2", InformationType.Number,
            "المنافذ", "2", "Features", "المميزات", 2);
        AddInfo(43, "Fast Charging", "true", InformationType.Boolean,
            "شحن سريع", "نعم", "Features", "المميزات", 3);

        // -------------------- Brand 9: PureGlow – Clean & ethical skincare --------------------

        // Product 49: AquaRenew Cleanser
        AddInfo(49, "Volume", "150", InformationType.Number,
            "الحجم", "150", "General", "عام", 1);
        AddInfo(49, "Vegan", "true", InformationType.Boolean,
            "نباتي", "نعم", "Ethical", "أخلاقي", 2);
        AddInfo(49, "Cruelty Free", "true", InformationType.Boolean,
            "خالي من القسوة", "نعم", "Ethical", "أخلاقي", 3);
        AddInfo(49, "Skin Type", "All skin types", InformationType.String,
            "نوع البشرة", "جميع أنواع البشرة", "Usage", "الاستخدام", 4);

        // -------------------- Brand 10: Trendora – Curated fashion for trendsetters --------------------

        // Product 55: VelvetEdge Dress
        AddInfo(55, "Material", "Velvet", InformationType.String,
            "المادة", "قطيفة", "General", "عام", 1);
        AddInfo(55, "Length", "110", InformationType.Number,
            "الطول", "110", "Dimensions", "الأبعاد", 2);
        AddInfo(55, "Lining", "Satin", InformationType.String,
            "البطانة", "ساتان", "Features", "المميزات", 3);

        // Product 57: ChromaSneak Shoes
        AddInfo(57, "Material", "Color-shifting Synthetic", InformationType.String,
            "المادة", "صناعي متغير اللون", "General", "عام", 1);
        AddInfo(57, "Weight", "350", InformationType.Number,
            "الوزن", "350", "Dimensions", "الأبعاد", 2);
        AddInfo(57, "Color Changing", "true", InformationType.Boolean,
            "تغير اللون", "نعم", "Features", "المميزات", 3);

        builder.HasData(productInfos);
    }
}