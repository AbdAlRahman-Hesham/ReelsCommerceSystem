using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_Product_Entity_Add_ProductColorMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProductColor");

            migrationBuilder.CreateTable(
                name: "ProductColorMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductColorId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "ProductColor",
                columns: new[] { "Id", "ArName", "CreatedAt", "HexCode", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "أحمر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#FF0000", "Red", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, "أزرق", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#0000FF", "Blue", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "أخضر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#008000", "Green", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "أسود", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#000000", "Black", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, "أبيض", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#FFFFFF", "White", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, "أصفر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#FFFF00", "Yellow", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, "أرجواني", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#800080", "Purple", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, "برتقالي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#FFA500", "Orange", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, "وردي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#FFC0CB", "Pink", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, "رمادي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "#808080", "Gray", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductColorMapping_ProductColorId",
                table: "ProductColorMapping",
                column: "ProductColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColorMapping_ProductId",
                table: "ProductColorMapping",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductColorMapping");

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.CreateTable(
                name: "ProductProductColor",
                columns: table => new
                {
                    AvailableColorsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductColor", x => new { x.AvailableColorsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductProductColor_ProductColor_AvailableColorsId",
                        column: x => x.AvailableColorsId,
                        principalTable: "ProductColor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductColor_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductColor_ProductsId",
                table: "ProductProductColor",
                column: "ProductsId");
        }
    }
}
