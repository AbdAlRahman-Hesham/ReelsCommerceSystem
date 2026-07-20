using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAverageRatingAndNumOfReviewsToProductsAndBrands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "NumOfDislikes",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfLikes",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "AverageRating",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfReviews",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductReviewDislikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviewDislikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReviewDislikes_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReviewLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviewLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReviewLikes_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(268), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1615), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1621), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1624), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1626), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1628), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1630), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1632), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1634), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1636), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1638), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1640), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1642), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1644), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1646), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1648), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1650), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1653), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1655), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1701), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1703), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1705), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1707), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1709), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1711), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1713), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1715), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1717), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1719), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1721), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1723), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1725), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1727), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1729), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1731), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1733), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1735), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1737), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1739), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1742), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1744), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1773), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1775), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1777), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1779), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1781), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1783), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1785), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1787), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1790), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1792), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1794), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1796), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1799), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1801), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1803), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1805), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1807), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1809), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1812), new DateTime(2026, 7, 16, 17, 1, 40, 393, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 401, DateTimeKind.Utc).AddTicks(8897), 0, new DateTime(2026, 7, 16, 17, 1, 40, 401, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2109), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2149), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2153), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2158), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2162), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2191), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2194), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2198), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2202), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2206), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2209), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2212), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2237), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2241), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2245), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2248), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2251), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2254), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2258), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2262), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2273), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2277), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2280), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2283), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2308), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2312), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2316), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2319), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2323), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2326), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2329), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2333), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2337), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2340), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2343), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2373), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2377), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2381), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2385), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2388), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2391), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2395), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2398), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2402), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2405), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2409), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2433), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2436), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2440), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2444), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2454), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2457), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2460), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2463), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2467), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2471), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2474), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2478), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2481), 0, new DateTime(2026, 7, 16, 17, 1, 40, 402, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId_UserId",
                table: "Reviews",
                columns: new[] { "ProductId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviewDislikes_ReviewId",
                table: "ProductReviewDislikes",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviewLikes_ReviewId",
                table: "ProductReviewLikes",
                column: "ReviewId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductReviewDislikes");

            migrationBuilder.DropTable(
                name: "ProductReviewLikes");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ProductId_UserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "NumOfDislikes",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "NumOfLikes",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NumOfReviews",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(5420), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7274), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7287), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7291), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7295), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7299), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7303), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7344), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7348), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7352), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7356), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7360), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7364), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7367), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7371), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7375), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7441), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7445), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7449), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7453), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7457), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7460), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7464), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7468), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7471), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7475), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7479), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7483), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7487), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7490), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7495), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7498), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7501), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7505), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7509), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7512), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7516), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7520), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7524), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7527), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7531), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7535), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7539), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7542), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7546), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7549), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7553), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7557), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7561), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7564), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7568), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7572), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7576), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7580), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7584), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7587), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7608), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7612), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7616), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7620), new DateTime(2026, 7, 13, 22, 44, 36, 767, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 782, DateTimeKind.Utc).AddTicks(5790), new DateTime(2026, 7, 13, 22, 44, 36, 782, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1098), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1122), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1138), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1146), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1153), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1160), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1167), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1176), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1184), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1197), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1319), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1343), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1406), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1413), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1420), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1428), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1434), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1441), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1451), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1462), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1469), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1476), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1532), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1538), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1545), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1553), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1561), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1569), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1590), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1596), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1603), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1611), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1618), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1681), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1689), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1697), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1704), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1713), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1720), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1727), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1734), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1741), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1748), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1779), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1842), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1851), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1858), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1864), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1873), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1881), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1889), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1896), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1903), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1910), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1917), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1925), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1933), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1941), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1947), new DateTime(2026, 7, 13, 22, 44, 36, 783, DateTimeKind.Utc).AddTicks(1948) });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }
    }
}
