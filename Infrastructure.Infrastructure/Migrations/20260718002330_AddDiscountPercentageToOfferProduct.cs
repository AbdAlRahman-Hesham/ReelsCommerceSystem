using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountPercentageToOfferProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "OfferProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPercentage",
                table: "OfferProducts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OfferProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "OfferProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "DiscountPercentage", "Id", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(1744), 0m, 0, new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "DiscountPercentage", "Id", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(2285), 0m, 0, new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 2, 14 },
                columns: new[] { "CreatedAt", "DiscountPercentage", "Id", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(2287), 0m, 0, new DateTime(2026, 7, 18, 0, 23, 25, 145, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(2725), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3440), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3443), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3445), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3446), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3448), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3450), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3451), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3453), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3455), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3456), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3458), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3460), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3461), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3463), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3464), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3466), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3467), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3469), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3470), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3472), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3474), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3476), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3496), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3498), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3499), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3532), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3534), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3535), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3537), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3538), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3540), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3542), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3543), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3545), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3546), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3548), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3550), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3551), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3553), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3554), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3557), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3558), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3560), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3561), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3563), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3564), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3566), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3568), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3569), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3571), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3573), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3574), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3576), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3577), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3579), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3580), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3582), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3583), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3585), new DateTime(2026, 7, 18, 0, 23, 25, 152, DateTimeKind.Utc).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 160, DateTimeKind.Utc).AddTicks(7127), new DateTime(2026, 7, 18, 0, 23, 25, 160, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(207), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(213), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(217), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(220), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(255), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(258), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(262), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(265), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(268), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(272), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(274), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(277), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(280), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(284), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(303), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(328), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(331), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(334), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(337), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(340), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(344), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(347), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(350), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(352), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(356), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(359), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(362), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(385), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(388), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(397), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(400), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(404), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(407), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(410), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(413), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(415), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(419), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(422), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(444), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(447), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(450), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(453), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(456), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(460), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(469), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(472), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(475), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(478), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(481), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(484), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(487), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(491), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(493), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(496), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(499), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(502), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(506), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(509), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(512), new DateTime(2026, 7, 18, 0, 23, 25, 161, DateTimeKind.Utc).AddTicks(512) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "OfferProducts");

            migrationBuilder.DropColumn(
                name: "DiscountPercentage",
                table: "OfferProducts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OfferProducts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "OfferProducts");

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

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(5506), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6123), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6126), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6128), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6129), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6131), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6132), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6134), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6135), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6137), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6138), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6140), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6141), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6143), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6144), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6145), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6147), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6176), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6177), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6179), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6180), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6195), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6197), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6198), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6199), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6201), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6202), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6204), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6205), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6207), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6208), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6209), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6211), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6212), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6214), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6215), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6217), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6218), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6221), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6223), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6224), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6226), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6227), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6228), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6230), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6231), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6233), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6234), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6236), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6237), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6239), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6240), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6242), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6243), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6245), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6246), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6247), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6249), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6250), new DateTime(2026, 7, 16, 17, 4, 52, 909, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(125), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2719), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2725), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2729), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2732), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2735), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2738), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2741), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2744), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2747), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2750), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2753), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2785), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2788), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2804), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2808), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2811), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2813), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2816), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2819), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2823), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2826), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2829), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2852), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2855), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2858), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2861), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2864), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2867), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2875), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2878), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2882), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2885), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2888), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2910), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2913), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2916), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2919), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2922), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2925), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2928), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2931), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2934), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2937), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2945), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2948), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2970), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2973), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2976), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2979), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2982), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2985), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2989), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2991), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2994), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2997), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(3000), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(3003), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(3006), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AverageRating", "CreatedAt", "NumOfReviews", "UpdatedAt" },
                values: new object[] { 0.0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(3015), 0, new DateTime(2026, 7, 16, 17, 4, 52, 916, DateTimeKind.Utc).AddTicks(3015) });

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
        }
    }
}
