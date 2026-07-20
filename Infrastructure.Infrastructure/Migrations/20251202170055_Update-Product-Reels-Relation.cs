using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductReelsRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reels_Products_ProductId",
                table: "Reels");

            migrationBuilder.DropIndex(
                name: "IX_Reels_ProductId",
                table: "Reels");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Reels");

            migrationBuilder.CreateTable(
                name: "ProductReels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ReelId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReels_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductReels_Reels_ReelId",
                        column: x => x.ReelId,
                        principalTable: "Reels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductReels_ReelId",
                table: "ProductReels",
                column: "ReelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductReels");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Reels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProductId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProductId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProductId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProductId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 14,
                column: "ProductId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 16,
                column: "ProductId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 17,
                column: "ProductId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 18,
                column: "ProductId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 19,
                column: "ProductId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 20,
                column: "ProductId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 21,
                column: "ProductId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 22,
                column: "ProductId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 23,
                column: "ProductId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 24,
                column: "ProductId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 25,
                column: "ProductId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 26,
                column: "ProductId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 27,
                column: "ProductId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 28,
                column: "ProductId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 29,
                column: "ProductId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 30,
                column: "ProductId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 31,
                column: "ProductId",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 32,
                column: "ProductId",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 33,
                column: "ProductId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 34,
                column: "ProductId",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 35,
                column: "ProductId",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 36,
                column: "ProductId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 37,
                column: "ProductId",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 38,
                column: "ProductId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 39,
                column: "ProductId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 40,
                column: "ProductId",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 41,
                column: "ProductId",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 42,
                column: "ProductId",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 43,
                column: "ProductId",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 44,
                column: "ProductId",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 45,
                column: "ProductId",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 46,
                column: "ProductId",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 47,
                column: "ProductId",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 48,
                column: "ProductId",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 49,
                column: "ProductId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 50,
                column: "ProductId",
                value: 59);

            migrationBuilder.CreateIndex(
                name: "IX_Reels_ProductId",
                table: "Reels",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reels_Products_ProductId",
                table: "Reels",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
