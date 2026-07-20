using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

public class RoleSeeding : IEntityTypeConfiguration<IdentityRole>
{
    // Static, deterministic role IDs
    public const string AdminRoleId       = "role-admin-0000-0000-000000000001";
    public const string UserRoleId        = "role-user-0000-0000-000000000002";
    public const string BrandOwnerRoleId  = "role-brandowner-000-000000000003";
    public const string BrandEmployeeRoleId = "role-brandemployee-0-000000000004";

    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id             = AdminRoleId,
                Name           = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "role-cs-admin"
            },
            new IdentityRole
            {
                Id             = UserRoleId,
                Name           = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = "role-cs-user"
            },
            new IdentityRole
            {
                Id             = BrandOwnerRoleId,
                Name           = "Brand Owner",
                NormalizedName = "BRAND OWNER",
                ConcurrencyStamp = "role-cs-brandowner"
            },
            new IdentityRole
            {
                Id             = BrandEmployeeRoleId,
                Name           = "Brand Employee",
                NormalizedName = "BRAND EMPLOYEE",
                ConcurrencyStamp = "role-cs-brandemployee"
            }
        );
    }
}
