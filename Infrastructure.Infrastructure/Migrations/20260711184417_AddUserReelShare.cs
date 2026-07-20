using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserReelShare : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserReelShares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReelId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReelShares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReelShares_Reels_ReelId",
                        column: x => x.ReelId,
                        principalTable: "Reels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserReelShares_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(140), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(851), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(854), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(856), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(857), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(859), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(860), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(862), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(863), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(865), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(867), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(868), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(870), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(871), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(873), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(874), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(876), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(877), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(879), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(880), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(914), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(916), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(932), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(934), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(935), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(937), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(938), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(940), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(941), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(943), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(944), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(946), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(947), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(949), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(950), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(952), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(953), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(955), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(957), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(958), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(960), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(962), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(964), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(965), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(967), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(968), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(970), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(971), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(973), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(974), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(976), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(978), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(979), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(981), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(982), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(984), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(985), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(987), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(988), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(990), new DateTime(2026, 7, 11, 18, 44, 12, 936, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(880), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6849), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6927), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6931), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6935), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6938), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6941), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6944), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6948), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6951), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6954), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6957), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6960), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6964), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6990), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6994), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6997), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7000), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7009), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7013), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7016), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7020), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7023), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7026), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7029), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7054), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7057), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7061), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7064), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7067), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7070), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7073), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7077), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7091), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7095), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7098), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7101), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7126), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7130), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7133), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7137), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7140), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7143), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7146), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7150), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7153), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7156), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7159), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7183), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7191), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7194), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7198), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7201), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7204), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7207), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7211), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7214), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7217), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7220), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7224), new DateTime(2026, 7, 11, 18, 44, 12, 944, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.CreateIndex(
                name: "IX_UserReelShares_ReelId",
                table: "UserReelShares",
                column: "ReelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReelShares_UserId",
                table: "UserReelShares",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserReelShares");

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(6654), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7601), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7605), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7607), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7609), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7611), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7613), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7615), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7617), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7655), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7661), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7663), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7665), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7667), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7669), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7671), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7673), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7677), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7679), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7707), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7708), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7710), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7711), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7713), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7714), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7716), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7717), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7718), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7720), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7721), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7723), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7724), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7726), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7727), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7728), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7750), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7751), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7753), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7754), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7756), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7757), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7759), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7760), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7762), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7763), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7765), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7766), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7767), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7769), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7770), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7772), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7773), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7775), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7776), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7778), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7779), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7780), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7782), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7783), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7785), new DateTime(2026, 7, 8, 22, 53, 35, 635, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 643, DateTimeKind.Utc).AddTicks(6792), new DateTime(2026, 7, 8, 22, 53, 35, 643, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(621), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(629), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(633), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(636), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(639), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(642), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(645), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(649), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(692), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(695), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(698), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(700), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(704), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(707), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(710), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(713), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(723), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(726), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(729), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(754), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(757), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(760), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(763), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(765), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(769), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(772), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(775), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(778), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(781), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(783), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(787), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(896), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(899), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(902), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(905), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(908), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(911), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(914), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(917), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(920), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(923), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(926), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1081), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1084), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1087), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1090), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1093), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1101), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1104), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1107), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1110), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1113), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1116), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1118), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1121), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1124), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1127), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1130), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1132), new DateTime(2026, 7, 8, 22, 53, 35, 644, DateTimeKind.Utc).AddTicks(1133) });
        }
    }
}
