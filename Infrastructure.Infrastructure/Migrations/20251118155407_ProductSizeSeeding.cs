using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductSizeSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductColor");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductColor");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductSizeMapping",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductColorMapping",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "Id", "Size" },
                values: new object[,]
                {
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "M" },
                    { 4, "L" },
                    { 5, "XL" },
                    { 6, "XXL" }
                });

            migrationBuilder.InsertData(
                table: "ProductSizeMapping",
                columns: new[] { "Id", "ProductId", "ProductSizeId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 18 },
                    { 2, 1, 2, 24 },
                    { 3, 1, 3, 30 },
                    { 4, 1, 4, 30 },
                    { 5, 1, 5, 18 },
                    { 6, 2, 2, 20 },
                    { 7, 2, 3, 24 },
                    { 8, 2, 4, 24 },
                    { 9, 2, 5, 12 },
                    { 10, 3, 3, 30 },
                    { 11, 3, 4, 37 },
                    { 12, 3, 5, 45 },
                    { 13, 3, 6, 38 },
                    { 14, 4, 1, 10 },
                    { 15, 4, 2, 20 },
                    { 16, 4, 3, 30 },
                    { 17, 4, 4, 25 },
                    { 18, 4, 5, 15 },
                    { 19, 5, 3, 80 },
                    { 20, 5, 4, 70 },
                    { 21, 5, 5, 50 },
                    { 22, 6, 2, 18 },
                    { 23, 6, 3, 27 },
                    { 24, 6, 4, 27 },
                    { 25, 6, 5, 18 },
                    { 26, 7, 3, 300 },
                    { 27, 8, 3, 120 },
                    { 28, 9, 3, 200 },
                    { 29, 10, 3, 150 },
                    { 30, 11, 3, 80 },
                    { 31, 12, 2, 45 },
                    { 32, 12, 3, 63 },
                    { 33, 12, 4, 45 },
                    { 34, 12, 5, 27 },
                    { 35, 13, 3, 120 },
                    { 36, 14, 3, 200 },
                    { 37, 15, 3, 150 },
                    { 38, 16, 3, 100 },
                    { 39, 17, 3, 180 },
                    { 40, 18, 3, 160 },
                    { 41, 19, 1, 12 },
                    { 42, 19, 2, 24 },
                    { 43, 19, 3, 36 },
                    { 44, 19, 4, 30 },
                    { 45, 19, 5, 18 },
                    { 46, 20, 2, 25 },
                    { 47, 20, 3, 35 },
                    { 48, 20, 4, 25 },
                    { 49, 20, 5, 15 },
                    { 50, 21, 3, 30 },
                    { 51, 21, 4, 45 },
                    { 52, 21, 5, 45 },
                    { 53, 21, 6, 30 },
                    { 54, 22, 3, 24 },
                    { 55, 22, 4, 28 },
                    { 56, 22, 5, 28 },
                    { 57, 23, 1, 30 },
                    { 58, 23, 2, 50 },
                    { 59, 23, 3, 60 },
                    { 60, 23, 4, 40 },
                    { 61, 23, 5, 20 },
                    { 62, 24, 2, 28 },
                    { 63, 24, 3, 49 },
                    { 64, 24, 4, 42 },
                    { 65, 24, 5, 21 },
                    { 66, 25, 3, 110 },
                    { 67, 26, 3, 150 },
                    { 68, 27, 3, 180 },
                    { 69, 28, 3, 160 },
                    { 70, 29, 3, 200 },
                    { 71, 30, 3, 180 },
                    { 72, 31, 3, 130 },
                    { 73, 32, 3, 90 },
                    { 74, 33, 3, 100 },
                    { 75, 34, 3, 140 },
                    { 76, 35, 3, 160 },
                    { 77, 36, 2, 40 },
                    { 78, 36, 3, 60 },
                    { 79, 36, 4, 60 },
                    { 80, 36, 5, 40 },
                    { 81, 37, 3, 110 },
                    { 82, 38, 3, 100 },
                    { 83, 39, 3, 180 },
                    { 84, 40, 3, 150 },
                    { 85, 41, 3, 90 },
                    { 86, 42, 3, 200 },
                    { 87, 43, 3, 150 },
                    { 88, 44, 3, 180 },
                    { 89, 45, 3, 220 },
                    { 90, 46, 3, 140 },
                    { 91, 47, 3, 200 },
                    { 92, 48, 3, 130 },
                    { 93, 49, 3, 160 },
                    { 94, 50, 3, 140 },
                    { 95, 51, 3, 150 },
                    { 96, 52, 3, 130 },
                    { 97, 53, 3, 120 },
                    { 98, 54, 3, 160 },
                    { 99, 55, 1, 13 },
                    { 100, 55, 2, 22 },
                    { 101, 55, 3, 27 },
                    { 102, 55, 4, 18 },
                    { 103, 55, 5, 10 },
                    { 104, 56, 2, 20 },
                    { 105, 56, 3, 28 },
                    { 106, 56, 4, 20 },
                    { 107, 56, 5, 12 },
                    { 108, 57, 3, 120 },
                    { 109, 58, 3, 70 },
                    { 110, 59, 1, 15 },
                    { 111, 59, 2, 37 },
                    { 112, 59, 3, 52 },
                    { 113, 59, 4, 30 },
                    { 114, 59, 5, 16 },
                    { 115, 60, 3, 200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductSizeMapping",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductSizeMapping");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductColorMapping");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductSize",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductSize",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductColor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductColor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
