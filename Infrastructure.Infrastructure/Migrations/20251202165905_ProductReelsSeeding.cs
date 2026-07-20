using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductReelsSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReels_Products_ProductsId",
                table: "ProductReels");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReels_Reels_ReelsId",
                table: "ProductReels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductReels",
                table: "ProductReels");

            migrationBuilder.RenameColumn(
                name: "ReelsId",
                table: "ProductReels",
                newName: "ReelId");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "ProductReels",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReels_ReelsId",
                table: "ProductReels",
                newName: "IX_ProductReels_ReelId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductReels",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductReels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductReels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductReels",
                table: "ProductReels",
                column: "Id");

            migrationBuilder.InsertData(
                table: "ProductReels",
                columns: new[] { "Id", "CreatedAt", "ProductId", "ReelId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 1, 1, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 2, 1, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 1, 2, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 2, 2, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 3, 2, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 1, 3, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 2, 3, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 3, 3, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 4, 3, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 1, 4, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 2, 4, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 3, 4, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 4, 4, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 5, 4, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 1, 5, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 2, 5, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 3, 5, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 4, 5, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 5, 5, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 20, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 6, 5, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 21, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 7, 6, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 22, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 7, 7, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 23, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 8, 7, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 24, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 7, 8, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 25, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 8, 8, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 26, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 9, 8, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 27, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 7, 9, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 28, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 8, 9, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 29, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 9, 9, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 30, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 10, 9, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 31, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 7, 10, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 32, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 8, 10, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 33, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 9, 10, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 34, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 10, 10, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 35, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 11, 10, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 36, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 13, 11, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 37, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 14, 11, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 38, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 15, 11, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 39, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 16, 11, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 40, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 17, 11, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 41, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 18, 11, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 42, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 13, 12, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 43, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 13, 13, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 44, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 14, 13, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 45, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 13, 14, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 46, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 14, 14, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 47, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 15, 14, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 48, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 13, 15, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 49, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 14, 15, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 50, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 15, 15, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 51, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 16, 15, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 52, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 19, 16, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 53, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 20, 16, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 54, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 21, 16, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 55, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 22, 16, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 56, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 23, 16, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 57, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 19, 17, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 58, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 20, 17, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 59, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 21, 17, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 60, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 22, 17, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 61, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 23, 17, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 62, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 24, 17, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 63, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 19, 18, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 64, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 19, 19, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 65, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 20, 19, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 66, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 19, 20, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 67, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 20, 20, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 68, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 21, 20, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 69, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 25, 21, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 70, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 26, 21, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 71, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 27, 21, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 72, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 28, 21, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 73, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 25, 22, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 74, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 26, 22, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 75, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 27, 22, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 76, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 28, 22, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 77, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 29, 22, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 78, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 25, 23, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 79, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 26, 23, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 80, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 27, 23, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 81, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 28, 23, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 82, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 29, 23, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 83, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 30, 23, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 84, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 25, 24, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 85, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 25, 25, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 86, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 26, 25, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 87, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 31, 26, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 88, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 32, 26, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 89, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 33, 26, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 90, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 31, 27, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 91, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 32, 27, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 92, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 33, 27, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 93, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 34, 27, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 94, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 31, 28, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 95, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 32, 28, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 96, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 33, 28, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 97, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 34, 28, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 98, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 35, 28, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 99, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 31, 29, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 100, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 32, 29, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 101, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 33, 29, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 102, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 34, 29, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 103, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 35, 29, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 104, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 36, 29, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 105, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 31, 30, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 106, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 37, 31, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 107, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 38, 31, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 108, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 37, 32, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 109, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 38, 32, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 110, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 39, 32, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 111, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 37, 33, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 112, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 38, 33, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 113, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 39, 33, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 114, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 40, 33, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 115, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 37, 34, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 116, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 38, 34, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 117, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 39, 34, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 118, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 40, 34, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 119, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 41, 34, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 120, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 37, 35, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 121, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 38, 35, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 122, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 39, 35, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 123, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 40, 35, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 124, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 41, 35, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 125, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 42, 35, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 126, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 43, 36, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 127, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 43, 37, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 128, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 44, 37, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 129, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 43, 38, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 130, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 44, 38, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 131, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 45, 38, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 132, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 43, 39, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 133, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 44, 39, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 134, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 45, 39, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 135, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 46, 39, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 136, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 43, 40, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 137, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 44, 40, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 138, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 45, 40, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 139, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 46, 40, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 140, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 47, 40, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 141, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 49, 41, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 142, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 50, 41, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 143, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 51, 41, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 144, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 52, 41, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 145, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 53, 41, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 146, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 54, 41, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 147, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 49, 42, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 148, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 49, 43, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 149, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 50, 43, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 150, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 49, 44, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 151, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 50, 44, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 152, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 51, 44, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 153, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 49, 45, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 154, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 50, 45, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 155, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 51, 45, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 156, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 52, 45, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 157, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 55, 46, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 158, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 56, 46, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 159, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 57, 46, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 160, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 58, 46, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 161, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 59, 46, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 162, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 55, 47, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 163, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 56, 47, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 164, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 57, 47, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 165, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 58, 47, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 166, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 59, 47, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 167, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 60, 47, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 168, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 55, 48, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 169, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 55, 49, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 170, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 56, 49, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 171, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 55, 50, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 172, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 56, 50, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 173, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), 57, 50, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductReels_ProductId",
                table: "ProductReels",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReels_Products_ProductId",
                table: "ProductReels",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReels_Reels_ReelId",
                table: "ProductReels",
                column: "ReelId",
                principalTable: "Reels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReels_Products_ProductId",
                table: "ProductReels");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReels_Reels_ReelId",
                table: "ProductReels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductReels",
                table: "ProductReels");

            migrationBuilder.DropIndex(
                name: "IX_ProductReels_ProductId",
                table: "ProductReels");

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductReels",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 173);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductReels");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductReels");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductReels");

            migrationBuilder.RenameColumn(
                name: "ReelId",
                table: "ProductReels",
                newName: "ReelsId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductReels",
                newName: "ProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReels_ReelId",
                table: "ProductReels",
                newName: "IX_ProductReels_ReelsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductReels",
                table: "ProductReels",
                columns: new[] { "ProductsId", "ReelsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReels_Products_ProductsId",
                table: "ProductReels",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReels_Reels_ReelsId",
                table: "ProductReels",
                column: "ReelsId",
                principalTable: "Reels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
