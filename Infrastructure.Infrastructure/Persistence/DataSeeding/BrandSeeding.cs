using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class BrandSeeding : IEntityTypeConfiguration<Brand>
{
    private static readonly DateTime _staticSeedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    private const string policy = "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>";
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasData(
            new Brand
            {
                Id = 1,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "NovaWear",
                Description = "NovaWear creates sustainable fashion for modern lifestyles.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a9/Amazon_logo.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user1",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Fashion",
                Country = "Egypt",
                Governorate = "Cairo",
                District = "Maadi",
                NumberOfEmployees = 50
            },
            new Brand
            {
                Id = 2,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "TechEase",
                Description = "TechEase designs smart accessories for a seamless daily life.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/Apple_logo_black.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user2",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Tech",
                Country = "Egypt",
                Governorate = "Giza",
                District = "6th of October",
                NumberOfEmployees = 30
            },
            new Brand
            {
                Id = 3,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "Glowify",
                Description = "Glowify offers natural skincare powered by modern innovation.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fa/Google_logo.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user3",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Beauty",
                Country = "Egypt",
                Governorate = "Alexandria",
                District = "Smouha",
                NumberOfEmployees = 20
            },
            new Brand
            {
                Id = 4,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "UrbanFuel",
                Description = "UrbanFuel brings premium streetwear for active youth.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/4/44/Microsoft_logo.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user4",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Fashion",
                Country = "Egypt",
                Governorate = "Cairo",
                District = "Nasr City",
                NumberOfEmployees = 40
            },

            new Brand
            {
                Id = 5,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "Zenora",
                Description = "Zenora promotes wellness with premium lifestyle products.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/5/51/YouTube_logo.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user5",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Lifestyle",
                Country = "Egypt",
                Governorate = "Giza",
                District = "Dokki",
                NumberOfEmployees = 25
            },

            new Brand
            {
                Id = 6,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "AeroFit",
                Description = "AeroFit crafts smart fitness gear for peak performance.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/3/31/Reddit_Logo_Full_2021.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user6",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Sports",
                Country = "Egypt",
                Governorate = "Alexandria",
                District = "Sidi Gaber",
                NumberOfEmployees = 35
            },

            new Brand
            {
                Id = 7,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "EcoNest",
                Description = "EcoNest builds eco-friendly home solutions for modern living.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2f/Instagram_logo_2016.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user7",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Home",
                Country = "Egypt",
                Governorate = "Cairo",
                District = "New Cairo",
                NumberOfEmployees = 60
            },

            new Brand
            {
                Id = 8,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "ByteWave",
                Description = "ByteWave delivers tech-driven accessories for everyday needs.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6f/Spotify_logo_with_text.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user8",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Tech",
                Country = "Egypt",
                Governorate = "Giza",
                District = "6th of October",
                NumberOfEmployees = 45
            },

            new Brand
            {
                Id = 9,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "PureGlow",
                Description = "PureGlow focuses on clean and ethical skincare essentials.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/0/09/Twitter_bird_logo_2012.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user9",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Beauty",
                Country = "Egypt",
                Governorate = "Alexandria",
                District = "Miami",
                NumberOfEmployees = 20
            },

            new Brand
            {
                Id = 10,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                DisplayName = "Trendora",
                Description = "Trendora curates unique fashion items for trendsetters worldwide.",
                LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/0/02/TikTok_logo_text.svg",
                ReturnPolicyAsHtml = "policy",
                UserId = "user10",
                Status = BrandStatus.APPROVED,
                CurrentStep = BrandStep.COMPLETED,
                RejectionReasonId = null,
                Category = "Fashion",
                Country = "Egypt",
                Governorate = "Cairo",
                District = "Maadi",
                NumberOfEmployees = 70
            }
        );

}   }



