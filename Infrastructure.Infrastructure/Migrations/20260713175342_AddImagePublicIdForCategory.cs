using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePublicIdForCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePublicId",
                table: "ProductCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImagePublicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(5482), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6101), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6106), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6107), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6108), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6110), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6111), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6112), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6114), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6115), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6116), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6119), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6120), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6122), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6135), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6137), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6138), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6139), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6141), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6172), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6173), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6175), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6176), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6177), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6179), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6180), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6182), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6183), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6185), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6186), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6187), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6189), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6190), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6191), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6193), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6194), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6196), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6197), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6198), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6200), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6201), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6203), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6204), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6206), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6207), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6208), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6210), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6211), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6213), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6214), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6216), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6217), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6218), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6221), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6222), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6224), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6225), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6227), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6228), new DateTime(2026, 7, 13, 17, 53, 39, 665, DateTimeKind.Utc).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(3298), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8266), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8316), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8320), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8324), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8327), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8330), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8333), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8336), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8339), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8343), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8345), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8348), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8373), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8376), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8401), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8405), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8408), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8410), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8414), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8417), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8420), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8423), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8426), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8449), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8453), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8457), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8460), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8463), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8466), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8468), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8478), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8481), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8485), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8488), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8491), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8514), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8517), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8520), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8524), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8527), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8529), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8532), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8535), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8538), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8542), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8551), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8574), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8577), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8581), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8584), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8587), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8590), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8593), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8596), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8599), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8602), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8605), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8608), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8611), new DateTime(2026, 7, 13, 17, 53, 39, 673, DateTimeKind.Utc).AddTicks(8611) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePublicId",
                table: "ProductCategory");

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5041), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5720), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5722), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5724), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5725), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5727), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5728), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5730), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5731), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5733), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5734), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5736), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5737), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5739), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5740), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5742), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5743), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5745), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5746), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5748), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5777), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5779), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5781), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5782), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5784), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5785), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5787), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5788), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5790), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5791), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5793), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5794), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5796), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5797), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5799), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5800), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5801), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5803), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5804), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5806), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5807), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5809), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5811), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5812), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5813), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5815), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5816), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5818), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5832), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5833), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5835), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5836), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5838), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5839), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5841), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5842), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5843), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5845), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5847), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5848), new DateTime(2026, 7, 13, 17, 27, 36, 555, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(30), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3091), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3131), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3136), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3140), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3143), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3146), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3150), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3153), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3158), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3161), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3184), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3187), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3191), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3218), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3221), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3225), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3228), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3231), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3235), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3238), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3241), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3245), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3248), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3251), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3276), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3285), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3289), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3292), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3295), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3298), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3301), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3305), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3308), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3312), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3315), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3318), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3342), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3346), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3349), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3353), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3356), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3365), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3368), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3372), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3376), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3379), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3382), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3406), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3410), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3414), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3417), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3420), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3423), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3426), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3430), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3433), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3442), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3446), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3449), new DateTime(2026, 7, 13, 17, 27, 36, 564, DateTimeKind.Utc).AddTicks(3449) });
        }
    }
}
