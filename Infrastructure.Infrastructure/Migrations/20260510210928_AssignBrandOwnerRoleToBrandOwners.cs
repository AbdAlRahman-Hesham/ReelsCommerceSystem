using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AssignBrandOwnerRoleToBrandOwners : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO UserRoles (UserId, RoleId)
                SELECT b.UserId, 'role-brandowner-000-000000000003'
                FROM Brands b
                WHERE NOT EXISTS (
                    SELECT 1 
                    FROM UserRoles ur 
                    WHERE ur.UserId = b.UserId 
                    AND ur.RoleId = 'role-brandowner-000-000000000003'
                );
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM UserRoles
                WHERE RoleId = 'role-brandowner-000-000000000003'
                AND UserId IN (SELECT UserId FROM Brands);
            ");
        }
    }
}
