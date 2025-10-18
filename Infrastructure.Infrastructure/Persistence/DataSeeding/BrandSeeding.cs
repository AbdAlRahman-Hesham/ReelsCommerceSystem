using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class BrandSeeding : IEntityTypeConfiguration<Brand>
{
    private static readonly DateTime _staticSeedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    private const string policy = "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>";
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasData([
            new(){Id = 1, CreatedAt = _staticSeedDate,DisplayName="NovaWear", Description="NovaWear creates sustainable fashion for modern lifestyles." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/a/a9/Amazon_logo.svg",VerificationStatus="Verified", ReturnPolicyAsHtml=policy},
            new(){Id = 2, CreatedAt = _staticSeedDate,DisplayName="TechEase", Description="TechEase designs smart accessories for a seamless daily life." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/0/08/Apple_logo_black.svg",VerificationStatus="Verified", ReturnPolicyAsHtml=policy},
            new(){Id = 3, CreatedAt = _staticSeedDate,DisplayName="Glowify", Description="Glowify offers natural skincare powered by modern innovation." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/f/fa/Google_logo.svg",VerificationStatus="Pending", ReturnPolicyAsHtml=policy},
            new(){Id = 4, CreatedAt = _staticSeedDate,DisplayName="UrbanFuel", Description="UrbanFuel brings premium streetwear for active youth." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/4/44/Microsoft_logo.svg",VerificationStatus="Verified", ReturnPolicyAsHtml=policy},
            new(){Id = 5, CreatedAt = _staticSeedDate,DisplayName="Zenora", Description="Zenora promotes wellness with premium lifestyle products." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/5/51/YouTube_logo.svg",VerificationStatus="Verified", ReturnPolicyAsHtml=policy},
            new(){Id = 6, CreatedAt = _staticSeedDate,DisplayName="AeroFit", Description="AeroFit crafts smart fitness gear for peak performance." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/3/31/Reddit_Logo_Full_2021.svg",VerificationStatus="Pending", ReturnPolicyAsHtml=policy},
            new(){Id = 7, CreatedAt = _staticSeedDate,DisplayName="EcoNest", Description="EcoNest builds eco-friendly home solutions for modern living." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/2/2f/Instagram_logo_2016.svg",VerificationStatus="Verified", ReturnPolicyAsHtml=policy},
            new(){Id = 8, CreatedAt = _staticSeedDate,DisplayName="ByteWave", Description="ByteWave delivers tech-driven accessories for everyday needs." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/6/6f/Spotify_logo_with_text.svg",VerificationStatus="Verified", ReturnPolicyAsHtml=policy},
            new(){Id = 9, CreatedAt = _staticSeedDate,DisplayName="PureGlow", Description="PureGlow focuses on clean and ethical skincare essentials." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/0/09/Twitter_bird_logo_2012.svg",VerificationStatus="Pending", ReturnPolicyAsHtml=policy},
            new(){Id = 10,CreatedAt = _staticSeedDate, DisplayName="Trendora", Description="Trendora curates unique fashion items for trendsetters worldwide." , LogoUrl="https://upload.wikimedia.org/wikipedia/commons/0/02/TikTok_logo_text.svg",VerificationStatus="Verified", ReturnPolicyAsHtml=policy}
        ]);
    }
}
