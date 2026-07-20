using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBrandLogoCoverPublicId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverPublicId",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoPublicId",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverPublicId", "LogoPublicId" },
                values: new object[] { null, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverPublicId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "LogoPublicId",
                table: "Brands");

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1170), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1808), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1813), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1814), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1816), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1817), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1819), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1820), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1822), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1823), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1852), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1853), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1855), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1857), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1858), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1859), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1861), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1862), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1864), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1865), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1867), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1868), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1870), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1871), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1873), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1874), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1876), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1877), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1879), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1880), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1882), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1883), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1885), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1886), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1888), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1908), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1909), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1911), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1912), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1914), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1915), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1917), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1919), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1920), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1921), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1923), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1924), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1926), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1927), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1940), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1942), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1943), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1945), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1946), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1948), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1949), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1950), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1952), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1953), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1954), new DateTime(2026, 7, 8, 22, 22, 17, 937, DateTimeKind.Utc).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(3152), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8790), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8801), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8806), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8811), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8815), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8819), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8824), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8828), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8881), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8887), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8925), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8929), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8934), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8938), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8943), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8947), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8951), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8954), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8958), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8991), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8995), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(8999), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9003), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9006), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9011), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9025), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9030), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9035), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9039), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9042), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9047), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9078), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9082), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9085), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9090), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9094), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9098), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9103), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9107), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9110), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9114), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9135), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9167), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9172), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9176), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9180), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9184), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9188), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9192), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9197), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9201), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9206), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9210), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9213), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9218), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9222), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9238), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9243), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9247), new DateTime(2026, 7, 8, 22, 22, 17, 948, DateTimeKind.Utc).AddTicks(9248) });
        }
    }
}
