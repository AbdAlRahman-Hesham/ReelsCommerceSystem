using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EnsureAllUsersHaveUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO UserRoles (UserId, RoleId)
                SELECT u.Id, 'role-user-0000-0000-000000000002'
                FROM Users u
                WHERE NOT EXISTS (
                    SELECT 1 
                    FROM UserRoles ur 
                    WHERE ur.UserId = u.Id 
                    AND ur.RoleId = 'role-user-0000-0000-000000000002'
                );
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Optional: Remove 'User' role assignments made by this migration.
            // However, since 'User' is a base role, we might want to keep it.
            // For safety and symmetry, we can remove it from users who only have it because of this.
        }
    }
}
