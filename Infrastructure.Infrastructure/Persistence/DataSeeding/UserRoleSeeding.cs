using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

/// <summary>
/// Seeds the UserRoles join table.
/// - Admin accounts (id "1"–"10"):  Admin + User
/// - Regular user accounts (id "user1"–"user10"):  User
/// </summary>
public class UserRoleSeeding : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    private static readonly string[] _adminIds =
        { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

    private static readonly string[] _userIds =
        { "user1", "user2", "user3", "user4", "user5",
          "user6", "user7", "user8", "user9", "user10" };

    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        var records = new List<IdentityUserRole<string>>();

        // Admins → Admin + User + Brand Owner
        foreach (var adminId in _adminIds)
        {
            records.Add(new IdentityUserRole<string>
            {
                UserId = adminId,
                RoleId = RoleSeeding.AdminRoleId
            });
            records.Add(new IdentityUserRole<string>
            {
                UserId = adminId,
                RoleId = RoleSeeding.UserRoleId
            });
            records.Add(new IdentityUserRole<string>
            {
                UserId = adminId,
                RoleId = RoleSeeding.BrandOwnerRoleId
            });
        }

        // Regular users → User role only
        foreach (var userId in _userIds)
        {
            records.Add(new IdentityUserRole<string>
            {
                UserId = userId,
                RoleId = RoleSeeding.UserRoleId
            });
        }

        builder.HasData(records);
    }
}
