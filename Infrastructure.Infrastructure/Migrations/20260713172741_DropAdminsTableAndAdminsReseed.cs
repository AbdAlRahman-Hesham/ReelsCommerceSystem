using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable
#pragma warning disable CA1814

namespace ReelsCommerceSystem.Infrastructure.Migrations;

public partial class DropAdminsTableAndAdminsReseed : Migration
{
    private const string AdminHash = "AQAAAAEAACcQAAAAEIpyyMPcNeei3/WytkEumEu2aMbVRzav8jHAPUvwYnmuPbO9YJIpj1xMATiocNF4cQ==";
    private const string SecurityStamp = "STATIC-SECURITY-STAMP";
    private const string ConcurrencyStamp = "STATIC-CONCURRENCY-STAMP";
    private const string SeedDate = "2024-01-01 00:00:00";

    private static readonly (string Id, string Name, string Email)[] Admins = new[]
    {
        ("1", "Abdalrahman", "Abdalrahman@alluvo.life"),
        ("2", "Abdallah", "Abdallah@alluvo.life"),
        ("3", "Esraa", "Esraa@alluvo.life"),
        ("4", "Ashrakat", "Ashrakat@alluvo.life"),
        ("5", "Mariam", "Mariam@alluvo.life"),
        ("6", "Nada", "Nada@alluvo.life"),
        ("7", "Tasneem", "Tasneem@alluvo.life"),
        ("8", "Abdaljawad", "Abdaljawad@alluvo.life"),
        ("9", "Suzan", "Suzan@alluvo.life"),
        ("10", "Aya", "Aya@alluvo.life"),
    };

    protected override void Up(MigrationBuilder migrationBuilder)
    {
        // Drop orphan Admins table
        migrationBuilder.Sql("DROP TABLE IF EXISTS [Admins]");

        // Re-insert the 10 admin users (deleted by ClearDataAndResetIdentity migration)
        foreach (var (id, name, email) in Admins)
        {
            var columns = new[] { "Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "DisplayName", "FirstName", "LastName", "ImageURL", "Gender", "CreatedAt", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnabled", "AccessFailedCount", "IsBanned" };
            var values = new object[] { id, name, name.ToUpper(), email, email.ToUpper(), true, name, name, "Admin", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "", SeedDate, AdminHash, SecurityStamp, ConcurrencyStamp, false, false, false, 0, false };
            migrationBuilder.InsertData(table: "Users", columns: columns, values: values);

            var roleColumns = new[] { "RoleId", "UserId" };
            migrationBuilder.InsertData(table: "UserRoles", columns: roleColumns, values: new object[] { "role-admin-0000-0000-000000000001", id });
            migrationBuilder.InsertData(table: "UserRoles", columns: roleColumns, values: new object[] { "role-user-0000-0000-000000000002", id });
            migrationBuilder.InsertData(table: "UserRoles", columns: roleColumns, values: new object[] { "role-brandowner-000-000000000003", id });
        }
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        foreach (var (id, name, email) in Admins)
        {
            migrationBuilder.DeleteData(table: "UserRoles", keyColumns: new[] { "UserId", "RoleId" }, keyValues: new object[] { id, "role-brandowner-000-000000000003" });
            migrationBuilder.DeleteData(table: "UserRoles", keyColumns: new[] { "UserId", "RoleId" }, keyValues: new object[] { id, "role-user-0000-0000-000000000002" });
            migrationBuilder.DeleteData(table: "UserRoles", keyColumns: new[] { "UserId", "RoleId" }, keyValues: new object[] { id, "role-admin-0000-0000-000000000001" });
            migrationBuilder.DeleteData(table: "Users", keyColumn: "Id", keyValue: id);
        }
    }
}
