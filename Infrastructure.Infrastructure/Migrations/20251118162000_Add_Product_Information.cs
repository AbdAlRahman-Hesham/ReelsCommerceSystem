using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_Product_Information : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInformation_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductInformation",
                columns: new[] { "Id", "ArGroup", "ArKey", "ArValue", "CreatedAt", "DisplayOrder", "Group", "Key", "ProductId", "Type", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { 1, "عام", "المادة", "قطن عضوي 100%", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "100% Organic Cotton" },
                    { 2, "الأبعاد", "الوزن", "150", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 1, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "150" },
                    { 3, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Sustainability", "Eco-Friendly", 1, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 4, "الاستدامة", "الشهادات", "معتمد GOTS، معيار المحتوى العضوي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Sustainability", "Certifications", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "GOTS Certified, Organic Content Standard" },
                    { 5, "العناية", "تعليمات العناية", "غسيل بالماكينة بماء بارد، تجفيف بالمجفف على حرارة منخفضة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, "Care", "Care Instructions", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Machine wash cold, Tumble dry low" },
                    { 6, "عام", "المادة", "دينيم معاد تدويره (85% قطن، 15% بوليستر)", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 2, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Recycled Denim (85% Cotton, 15% Polyester)" },
                    { 7, "الأبعاد", "الوزن", "800", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 2, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "800" },
                    { 8, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Sustainability", "Eco-Friendly", 2, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 9, "العناية", "العناية بالغسيل", "تنظيف جاف فقط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Care", "Wash Care", 2, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Dry clean only" },
                    { 10, "عام", "المادة", "بولي إيثيلين تيريفثاليت معاد تدويره، نعل مطاطي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 3, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Recycled PET, Rubber sole" },
                    { 11, "الأبعاد", "الوزن", "280", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 3, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "280" },
                    { 12, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Water Resistant", 3, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 13, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Sustainability", "Eco-Friendly", 3, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 14, "المواصفات", "طول الكابل", "1.5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Specifications", "Cable Length", 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1.5" },
                    { 15, "المميزات", "شحن سريع", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Fast Charging", 7, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 16, "تقني", "القدرة", "100", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Technical", "Wattage", 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "100" },
                    { 17, "الضمان", "فترة الضمان", "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Warranty", "Warranty Period", 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2" },
                    { 18, "البطارية", "عمر البطارية", "24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Battery", "Battery Life", 9, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "24" },
                    { 19, "المميزات", "إلغاء الضوضاء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Noise Cancellation", 9, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 20, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Waterproof", 9, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 21, "تقني", "إصدار البلوتوث", "5.2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Technical", "Bluetooth Version", 9, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "5.2" },
                    { 22, "الشاشة", "حجم الشاشة", "1.3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Display", "Screen Size", 11, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1.3" },
                    { 23, "الصحة", "مراقب معدل ضربات القلب", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Health", "Heart Rate Monitor", 11, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 24, "الصحة", "تتبع النوم", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Health", "Sleep Tracking", 11, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 25, "البطارية", "عمر البطارية", "7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Battery", "Battery Life", 11, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "7" },
                    { 26, "عام", "الحجم", "30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Volume", 13, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "30" },
                    { 27, "أخلاقي", "نباتي", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Ethical", "Vegan", 13, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 28, "أخلاقي", "خالي من القسوة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Ethical", "Cruelty Free", 13, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 29, "الاستخدام", "نوع البشرة", "جميع أنواع البشرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Usage", "Skin Type", 13, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All skin types" },
                    { 30, "المكونات", "المكونات الرئيسية", "فيتامين سي، حمض الهيالورونيك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, "Ingredients", "Key Ingredients", 13, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vitamin C, Hyaluronic Acid" },
                    { 31, "الحماية", "معامل الحماية", "50", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Protection", "SPF", 17, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "50" },
                    { 32, "عام", "الحجم", "50", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "General", "Volume", 17, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "50" },
                    { 33, "المكونات", "قائم على المعادن", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Ingredients", "Mineral Based", 17, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 34, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Water Resistant", 17, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 35, "عام", "المادة", "مزيج قطني", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 19, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Cotton Blend" },
                    { 36, "الأبعاد", "الوزن", "650", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 19, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "650" },
                    { 37, "عام", "النمط", "مقاس كبير", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "General", "Style", 19, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Oversized" },
                    { 38, "المميزات", "عدد الجيوب", "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Pocket Count", 19, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2" },
                    { 39, "عام", "المادة", "قماش شبكي، جلد صناعي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 21, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mesh, Synthetic Leather" },
                    { 40, "الأبعاد", "الوزن", "320", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 21, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "320" },
                    { 41, "المميزات", "منفس", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Breathable", 21, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 42, "المميزات", "نوع الإغلاق", "ربط بالرباط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Closure Type", 21, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lace-up" },
                    { 43, "الشاشة", "حجم الشاشة", "1.2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Display", "Screen Size", 31, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1.2" },
                    { 44, "البطارية", "عمر البطارية", "7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Battery", "Battery Life", 31, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "7" },
                    { 45, "الصحة", "مراقب معدل ضربات القلب", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Health", "Heart Rate Monitor", 31, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 46, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Waterproof", 31, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 47, "المواصفات", "نطاق الوزن", "25-5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Specifications", "Weight Range", 32, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "5-25" },
                    { 48, "المميزات", "قابل للتعديل", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Adjustable", 32, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 49, "عام", "المادة", "حديد، بلاستيك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "General", "Material", 32, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Steel, Plastic" },
                    { 50, "عام", "المادة", "خيزران", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 37, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bamboo" },
                    { 51, "الأبعاد", "الارتفاع", "35", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Height", 37, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "35" },
                    { 52, "المميزات", "قابل للتعتيم", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Dimmable", 37, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 53, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Sustainability", "Eco-Friendly", 37, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 54, "تقني", "القدرة", "65", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Technical", "Wattage", 43, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "65" },
                    { 55, "المميزات", "المنافذ", "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Ports", 43, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2" },
                    { 56, "المميزات", "شحن سريع", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Fast Charging", 43, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 57, "عام", "الحجم", "150", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Volume", 49, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "150" },
                    { 58, "أخلاقي", "نباتي", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Ethical", "Vegan", 49, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 59, "أخلاقي", "خالي من القسوة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Ethical", "Cruelty Free", 49, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 60, "الاستخدام", "نوع البشرة", "جميع أنواع البشرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Usage", "Skin Type", 49, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All skin types" },
                    { 61, "عام", "المادة", "قطيفة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 55, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Velvet" },
                    { 62, "الأبعاد", "الطول", "110", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Length", 55, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "110" },
                    { 63, "المميزات", "البطانة", "ساتان", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Lining", 55, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Satin" },
                    { 64, "عام", "المادة", "صناعي متغير اللون", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 57, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Color-shifting Synthetic" },
                    { 65, "الأبعاد", "الوزن", "350", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 57, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "350" },
                    { 66, "المميزات", "تغير اللون", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Color Changing", 57, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInformation_ProductId",
                table: "ProductInformation",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInformation");
        }
    }
}
