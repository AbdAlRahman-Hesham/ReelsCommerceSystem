using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DisputeStatusFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Orders");


            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "WishlistItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UserInterests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "UserInterests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UserBrandFollows",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "UserBrandFollows",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ArDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Interests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Interests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Disputes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "BrandReviewLikes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "BrandReviewLikes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "BrandReviewDislikes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "BrandReviewDislikes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "BrandReview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "AiChats",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HexCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInformation_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductColorMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductColorId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColorMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductColorMapping_ProductColor_ProductColorId",
                        column: x => x.ProductColorId,
                        principalTable: "ProductColor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductColorMapping_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizeMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductSizeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizeMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSizeMapping_ProductSize_ProductSizeId",
                        column: x => x.ProductSizeId,
                        principalTable: "ProductSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizeMapping_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "ArName", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "ملابس", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Clothing", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, "أحذية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Footwear", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "إكسسوارات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Accessories", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "إلكترونيات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Electronics", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, "سماعات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Audio", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, "أجهزة قابلة للارتداء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Wearables", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, "العناية بالبشرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Skincare", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, "الملابس الخارجية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Outerwear", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, "لياقة بدنية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fitness", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, "العافية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Wellness", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, "منزل", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Home", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, "قرطاسية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Stationery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, "معدات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Equipment", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, "ديكور منزلي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Home Decor", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, "بستنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gardening", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, "عبير المنزل", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Home Fragrance", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, "أجهزة منزلية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Appliances", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, "تخزين", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Storage", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, "مكتب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Office", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 20, "ملابس رياضية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Apparel", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ProductColor",
                columns: new[] { "Id", "ArName", "HexCode", "Name", "Quantity" },
                values: new object[,]
                {
                    { 1, "أحمر", "#FF0000", "Red", 0 },
                    { 2, "أزرق", "#0000FF", "Blue", 0 },
                    { 3, "أخضر", "#008000", "Green", 0 },
                    { 4, "أسود", "#000000", "Black", 0 },
                    { 5, "أبيض", "#FFFFFF", "White", 0 },
                    { 6, "أصفر", "#FFFF00", "Yellow", 0 },
                    { 7, "أرجواني", "#800080", "Purple", 0 },
                    { 8, "برتقالي", "#FFA500", "Orange", 0 },
                    { 9, "وردي", "#FFC0CB", "Pink", 0 },
                    { 10, "رمادي", "#808080", "Gray", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductInformation",
                columns: new[] { "Id", "ArGroup", "ArKey", "ArValue", "CreatedAt", "DisplayOrder", "Group", "Key", "ProductId", "Type", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { 1, "عام", "المادة", "قطن عضوي 100%", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "100% Organic Cotton" },
                    { 2, "الأبعاد", "الوزن", "150", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 1, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "150" },
                    { 3, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Sustainability", "Eco-Friendly", 1, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 4, "الاستدامة", "الشهادات", "معتمد GOTS، معيار المحتوى العضوي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Sustainability", "Certifications", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "GOTS Certified, Organic Content Standard" },
                    { 5, "العناية", "تعليمات العناية", "غسيل بالماكينة بماء بارد، تجفيف بالمجفف على حرارة منخفضة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, "Care", "Care Instructions", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Machine wash cold, Tumble dry low" },
                    { 6, "عام", "المادة", "دينيم معاد تدويره (85% قطن، 15% بوليستر)", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 2, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Recycled Denim (85% Cotton, 15% Polyester)" },
                    { 7, "الأبعاد", "الوزن", "800", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 2, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "800" },
                    { 8, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Sustainability", "Eco-Friendly", 2, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 9, "العناية", "العناية بالغسيل", "تنظيف جاف فقط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Care", "Wash Care", 2, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Dry clean only" },
                    { 10, "عام", "المادة", "بولي إيثيلين تيريفثاليت معاد تدويره، نعل مطاطي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 3, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Recycled PET, Rubber sole" },
                    { 11, "الأبعاد", "الوزن", "280", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 3, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "280" },
                    { 12, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Water Resistant", 3, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 13, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Sustainability", "Eco-Friendly", 3, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 14, "المواصفات", "طول الكابل", "1.5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Specifications", "Cable Length", 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1.5" },
                    { 15, "المميزات", "شحن سريع", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Fast Charging", 7, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 16, "تقني", "القدرة", "100", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Technical", "Wattage", 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "100" },
                    { 17, "الضمان", "فترة الضمان", "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Warranty", "Warranty Period", 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2" },
                    { 18, "البطارية", "عمر البطارية", "24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Battery", "Battery Life", 9, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "24" },
                    { 19, "المميزات", "إلغاء الضوضاء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Noise Cancellation", 9, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 20, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Waterproof", 9, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 21, "تقني", "إصدار البلوتوث", "5.2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Technical", "Bluetooth Version", 9, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "5.2" },
                    { 22, "الشاشة", "حجم الشاشة", "1.3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Display", "Screen Size", 11, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1.3" },
                    { 23, "الصحة", "مراقب معدل ضربات القلب", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Health", "Heart Rate Monitor", 11, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 24, "الصحة", "تتبع النوم", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Health", "Sleep Tracking", 11, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 25, "البطارية", "عمر البطارية", "7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Battery", "Battery Life", 11, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "7" },
                    { 26, "عام", "الحجم", "30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Volume", 13, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "30" },
                    { 27, "أخلاقي", "نباتي", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Ethical", "Vegan", 13, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 28, "أخلاقي", "خالي من القسوة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Ethical", "Cruelty Free", 13, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 29, "الاستخدام", "نوع البشرة", "جميع أنواع البشرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Usage", "Skin Type", 13, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All skin types" },
                    { 30, "المكونات", "المكونات الرئيسية", "فيتامين سي، حمض الهيالورونيك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, "Ingredients", "Key Ingredients", 13, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vitamin C, Hyaluronic Acid" },
                    { 31, "الحماية", "معامل الحماية", "50", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Protection", "SPF", 17, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "50" },
                    { 32, "عام", "الحجم", "50", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "General", "Volume", 17, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "50" },
                    { 33, "المكونات", "قائم على المعادن", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Ingredients", "Mineral Based", 17, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 34, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Water Resistant", 17, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 35, "عام", "المادة", "مزيج قطني", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 19, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Cotton Blend" },
                    { 36, "الأبعاد", "الوزن", "650", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 19, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "650" },
                    { 37, "عام", "النمط", "مقاس كبير", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "General", "Style", 19, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Oversized" },
                    { 38, "المميزات", "عدد الجيوب", "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Pocket Count", 19, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2" },
                    { 39, "عام", "المادة", "قماش شبكي، جلد صناعي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 21, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mesh, Synthetic Leather" },
                    { 40, "الأبعاد", "الوزن", "320", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 21, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "320" },
                    { 41, "المميزات", "منفس", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Breathable", 21, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 42, "المميزات", "نوع الإغلاق", "ربط بالرباط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Closure Type", 21, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lace-up" },
                    { 43, "الشاشة", "حجم الشاشة", "1.2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Display", "Screen Size", 31, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1.2" },
                    { 44, "البطارية", "عمر البطارية", "7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Battery", "Battery Life", 31, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "7" },
                    { 45, "الصحة", "مراقب معدل ضربات القلب", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Health", "Heart Rate Monitor", 31, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 46, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Waterproof", 31, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 47, "المواصفات", "نطاق الوزن", "25-5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Specifications", "Weight Range", 32, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "5-25" },
                    { 48, "المميزات", "قابل للتعديل", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Adjustable", 32, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 49, "عام", "المادة", "حديد، بلاستيك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "General", "Material", 32, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Steel, Plastic" },
                    { 50, "عام", "المادة", "خيزران", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 37, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bamboo" },
                    { 51, "الأبعاد", "الارتفاع", "35", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Height", 37, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "35" },
                    { 52, "المميزات", "قابل للتعتيم", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Dimmable", 37, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 53, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Sustainability", "Eco-Friendly", 37, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 54, "تقني", "القدرة", "65", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Technical", "Wattage", 43, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "65" },
                    { 55, "المميزات", "المنافذ", "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Ports", 43, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2" },
                    { 56, "المميزات", "شحن سريع", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Fast Charging", 43, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 57, "عام", "الحجم", "150", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Volume", 49, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "150" },
                    { 58, "أخلاقي", "نباتي", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Ethical", "Vegan", 49, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 59, "أخلاقي", "خالي من القسوة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Ethical", "Cruelty Free", 49, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 60, "الاستخدام", "نوع البشرة", "جميع أنواع البشرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Usage", "Skin Type", 49, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All skin types" },
                    { 61, "عام", "المادة", "قطيفة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 55, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Velvet" },
                    { 62, "الأبعاد", "الطول", "110", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Length", 55, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "110" },
                    { 63, "المميزات", "البطانة", "ساتان", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Lining", 55, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Satin" },
                    { 64, "عام", "المادة", "صناعي متغير اللون", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 57, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Color-shifting Synthetic" },
                    { 65, "الأبعاد", "الوزن", "350", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 57, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "350" },
                    { 66, "المميزات", "تغير اللون", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Color Changing", 57, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" }
                });

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ArDescription", "CategoryId", "UpdatedAt" },
                values: new object[] { null, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "ProductColorMapping",
                columns: new[] { "Id", "ProductColorId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 4, 1, 48 },
                    { 2, 5, 1, 42 },
                    { 3, 3, 1, 30 },
                    { 4, 2, 2, 40 },
                    { 5, 4, 2, 24 },
                    { 6, 1, 2, 16 },
                    { 7, 4, 3, 52 },
                    { 8, 2, 3, 45 },
                    { 9, 5, 3, 30 },
                    { 10, 1, 3, 23 },
                    { 11, 3, 4, 40 },
                    { 12, 5, 4, 35 },
                    { 13, 10, 4, 25 },
                    { 14, 4, 5, 90 },
                    { 15, 5, 5, 60 },
                    { 16, 3, 5, 50 },
                    { 17, 10, 6, 36 },
                    { 18, 4, 6, 31 },
                    { 19, 2, 6, 23 },
                    { 20, 4, 7, 120 },
                    { 21, 2, 7, 90 },
                    { 22, 5, 7, 90 },
                    { 23, 4, 8, 60 },
                    { 24, 10, 8, 36 },
                    { 25, 5, 8, 24 },
                    { 26, 4, 9, 90 },
                    { 27, 2, 9, 60 },
                    { 28, 7, 9, 50 },
                    { 29, 4, 10, 75 },
                    { 30, 10, 10, 45 },
                    { 31, 5, 10, 30 },
                    { 32, 4, 11, 32 },
                    { 33, 2, 11, 28 },
                    { 34, 1, 11, 20 },
                    { 35, 4, 12, 63 },
                    { 36, 7, 12, 45 },
                    { 37, 9, 12, 36 },
                    { 38, 2, 12, 36 },
                    { 39, 5, 13, 72 },
                    { 40, 9, 13, 48 },
                    { 41, 5, 14, 140 },
                    { 42, 3, 14, 60 },
                    { 43, 5, 15, 75 },
                    { 44, 2, 15, 45 },
                    { 45, 7, 15, 30 },
                    { 46, 5, 16, 60 },
                    { 47, 9, 16, 40 },
                    { 48, 5, 17, 99 },
                    { 49, 6, 17, 81 },
                    { 50, 5, 18, 104 },
                    { 51, 9, 18, 56 },
                    { 52, 4, 19, 48 },
                    { 53, 10, 19, 42 },
                    { 54, 1, 19, 30 },
                    { 55, 4, 20, 45 },
                    { 56, 10, 20, 30 },
                    { 57, 2, 20, 25 },
                    { 58, 4, 21, 52 },
                    { 59, 1, 21, 37 },
                    { 60, 2, 21, 30 },
                    { 61, 6, 21, 31 },
                    { 62, 2, 22, 32 },
                    { 63, 4, 22, 28 },
                    { 64, 1, 22, 20 },
                    { 65, 4, 23, 100 },
                    { 66, 2, 23, 60 },
                    { 67, 1, 23, 40 },
                    { 68, 4, 24, 56 },
                    { 69, 5, 24, 49 },
                    { 70, 10, 24, 35 },
                    { 71, 3, 25, 44 },
                    { 72, 5, 25, 38 },
                    { 73, 10, 25, 28 },
                    { 74, 5, 26, 75 },
                    { 75, 7, 26, 45 },
                    { 76, 9, 26, 30 },
                    { 77, 5, 27, 81 },
                    { 78, 7, 27, 54 },
                    { 79, 9, 27, 45 },
                    { 80, 3, 28, 56 },
                    { 81, 5, 28, 56 },
                    { 82, 2, 28, 48 },
                    { 83, 5, 29, 120 },
                    { 84, 3, 29, 80 },
                    { 85, 5, 30, 99 },
                    { 86, 7, 30, 81 },
                    { 87, 4, 31, 52 },
                    { 88, 2, 31, 45 },
                    { 89, 1, 31, 33 },
                    { 90, 4, 32, 45 },
                    { 91, 10, 32, 27 },
                    { 92, 5, 32, 18 },
                    { 93, 4, 33, 45 },
                    { 94, 1, 33, 30 },
                    { 95, 2, 33, 25 },
                    { 96, 3, 34, 56 },
                    { 97, 4, 34, 49 },
                    { 98, 5, 34, 35 },
                    { 99, 2, 35, 64 },
                    { 100, 4, 35, 56 },
                    { 101, 5, 35, 40 },
                    { 102, 4, 36, 70 },
                    { 103, 2, 36, 50 },
                    { 104, 1, 36, 40 },
                    { 105, 6, 36, 40 },
                    { 106, 3, 37, 44 },
                    { 107, 5, 37, 38 },
                    { 108, 10, 37, 28 },
                    { 109, 3, 38, 35 },
                    { 110, 5, 38, 30 },
                    { 111, 2, 38, 20 },
                    { 112, 7, 38, 15 },
                    { 113, 3, 39, 81 },
                    { 114, 5, 39, 54 },
                    { 115, 10, 39, 45 },
                    { 116, 5, 40, 75 },
                    { 117, 3, 40, 45 },
                    { 118, 8, 40, 30 },
                    { 119, 5, 41, 54 },
                    { 120, 10, 41, 36 },
                    { 121, 3, 42, 80 },
                    { 122, 5, 42, 70 },
                    { 123, 10, 42, 50 },
                    { 124, 4, 43, 67 },
                    { 125, 2, 43, 45 },
                    { 126, 5, 43, 38 },
                    { 127, 4, 44, 72 },
                    { 128, 10, 44, 54 },
                    { 129, 2, 44, 27 },
                    { 130, 1, 44, 27 },
                    { 131, 4, 45, 110 },
                    { 132, 10, 45, 66 },
                    { 133, 5, 45, 44 },
                    { 134, 4, 46, 56 },
                    { 135, 7, 46, 35 },
                    { 136, 9, 46, 28 },
                    { 137, 2, 46, 21 },
                    { 138, 4, 47, 50 },
                    { 139, 2, 47, 40 },
                    { 140, 1, 47, 40 },
                    { 141, 6, 47, 36 },
                    { 142, 3, 47, 34 },
                    { 143, 10, 48, 58 },
                    { 144, 4, 48, 45 },
                    { 145, 5, 48, 27 },
                    { 146, 5, 49, 96 },
                    { 147, 3, 49, 64 },
                    { 148, 5, 50, 77 },
                    { 149, 9, 50, 63 },
                    { 150, 3, 51, 60 },
                    { 151, 5, 51, 52 },
                    { 152, 10, 51, 38 },
                    { 153, 5, 52, 65 },
                    { 154, 7, 52, 39 },
                    { 155, 9, 52, 26 },
                    { 156, 5, 53, 72 },
                    { 157, 9, 53, 48 },
                    { 158, 5, 54, 88 },
                    { 159, 2, 54, 72 },
                    { 160, 7, 55, 31 },
                    { 161, 4, 55, 27 },
                    { 162, 1, 55, 18 },
                    { 163, 9, 55, 14 },
                    { 164, 6, 56, 32 },
                    { 165, 8, 56, 28 },
                    { 166, 1, 56, 20 },
                    { 167, 4, 57, 36 },
                    { 168, 7, 57, 30 },
                    { 169, 2, 57, 24 },
                    { 170, 6, 57, 18 },
                    { 171, 1, 57, 12 },
                    { 172, 4, 58, 35 },
                    { 173, 7, 58, 21 },
                    { 174, 9, 58, 14 },
                    { 175, 1, 59, 45 },
                    { 176, 4, 59, 37 },
                    { 177, 2, 59, 30 },
                    { 178, 7, 59, 22 },
                    { 179, 9, 59, 16 },
                    { 180, 4, 60, 90 },
                    { 181, 10, 60, 60 },
                    { 182, 7, 60, 50 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColorMapping_ProductColorId",
                table: "ProductColorMapping",
                column: "ProductColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColorMapping_ProductId",
                table: "ProductColorMapping",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInformation_ProductId",
                table: "ProductInformation",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeMapping_ProductId",
                table: "ProductSizeMapping",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeMapping_ProductSizeId",
                table: "ProductSizeMapping",
                column: "ProductSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategory_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategory_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ProductColorMapping");

            migrationBuilder.DropTable(
                name: "ProductInformation");

            migrationBuilder.DropTable(
                name: "ProductSizeMapping");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "WishlistItems");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UserInterests");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "UserInterests");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UserBrandFollows");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "UserBrandFollows");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Reels");

            migrationBuilder.DropColumn(
                name: "ArDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Disputes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "BrandReviewLikes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "BrandReviewLikes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "BrandReviewDislikes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "BrandReviewDislikes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "BrandReview");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AiChats");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Disputes",
                newName: "StockStatus");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: "Footwear");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Category",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Category",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Category",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Category",
                value: "Audio");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Category",
                value: "Wearables");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Category",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Category",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Category",
                value: "Footwear");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Category",
                value: "Outerwear");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Category",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Category",
                value: "Fitness");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Category",
                value: "Wellness");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Category",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Category",
                value: "Wellness");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Category",
                value: "Stationery");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Category",
                value: "Wellness");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Category",
                value: "Wearables");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Category",
                value: "Equipment");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Category",
                value: "Fitness");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Category",
                value: "Apparel");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Category",
                value: "Home Decor");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Category",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "Category",
                value: "Gardening");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "Category",
                value: "Home Fragrance");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "Category",
                value: "Appliances");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "Category",
                value: "Home Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "Category",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "Category",
                value: "Storage");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "Category",
                value: "Audio");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "Category",
                value: "Office");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "Category",
                value: "Skincare");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "Category",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "Category",
                value: "Outerwear");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "Category",
                value: "Footwear");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "Category",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "Category",
                value: "Accessories");

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId1",
                table: "Orders",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
