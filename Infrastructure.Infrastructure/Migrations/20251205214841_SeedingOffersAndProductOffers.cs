using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingOffersAndProductOffers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "BrandId", "CreatedAt", "Description", "ImageUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 12, 5, 21, 48, 39, 147, DateTimeKind.Utc).AddTicks(3279), "Sale 30% on all Product", "https://drive.google.com/file/d/1oaqNd7ONKCa8AFG6myo22H9FWL6nMMaY/view?usp=drive_link", new DateTime(2025, 12, 5, 21, 48, 39, 147, DateTimeKind.Utc).AddTicks(3284) },
                    { 2, 3, new DateTime(2025, 12, 5, 21, 48, 39, 147, DateTimeKind.Utc).AddTicks(4662), "Buy 2 Get 50% Off", "https://drive.google.com/file/d/1UsBr52J5CZasFrPUbYhsh1q4q1_8L7Y7/view?usp=drive_link", new DateTime(2025, 12, 5, 21, 48, 39, 147, DateTimeKind.Utc).AddTicks(4662) }
                });

            migrationBuilder.InsertData(
                table: "OfferProducts",
                columns: new[] { "OfferId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "OfferProducts",
                keyColumns: new[] { "OfferId", "ProductId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
