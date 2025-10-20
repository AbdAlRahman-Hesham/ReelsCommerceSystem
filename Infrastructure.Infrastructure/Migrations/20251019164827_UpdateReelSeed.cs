using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReelSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "BrandId", "CreatedAt", "NumOfLikes", "NumOfWatches", "ProductId", "VideoUrl" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1200, 8000, 1, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 2, 1, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 2300, 15000, 2, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 3, 1, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 1800, 11000, 3, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 4, 1, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 2600, 20000, 4, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 5, 1, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 3400, 25000, 5, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 6, 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 800, 5000, 7, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 7, 2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 6000, 95000, 8, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 8, 2, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 9000, 30000, 9, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 9, 2, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 15000, 35000, 10, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 10, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 100000, 300000, 11, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 11, 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2000, 10000, 13, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 12, 3, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 5000, 20000, 14, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 13, 3, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 8000, 25000, 15, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 14, 3, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 10000, 40000, 16, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 15, 3, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 15000, 50000, 17, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 16, 4, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1700, 12000, 19, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 17, 4, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 2500, 18000, 20, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 18, 4, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 4000, 23000, 21, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 19, 4, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 5200, 30000, 22, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 20, 4, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 7500, 35000, 23, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 21, 5, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1300, 10000, 25, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 22, 5, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 2000, 14000, 26, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 23, 5, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 3600, 20000, 27, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 24, 5, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 4500, 26000, 28, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 25, 5, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 6000, 30000, 29, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 26, 6, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1800, 9000, 31, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 27, 6, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 2200, 15000, 32, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 28, 6, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 3500, 22000, 33, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 29, 6, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 4800, 28000, 34, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 30, 6, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 5200, 31000, 35, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 31, 7, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1500, 7000, 37, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 32, 7, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 2100, 13000, 38, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 33, 7, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 2700, 20000, 39, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 34, 7, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 4000, 26000, 40, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 35, 7, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 5200, 32000, 41, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 36, 8, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1800, 11000, 43, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 37, 8, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 2500, 16000, 44, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 38, 8, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 3900, 22000, 45, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 39, 8, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 4800, 27000, 46, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 40, 8, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 6500, 33000, 47, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 41, 9, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1200, 8000, 49, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 42, 9, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 2000, 12000, 50, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 43, 9, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 2700, 18000, 51, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 44, 9, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 3600, 25000, 52, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 45, 9, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 4900, 30000, 53, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 46, 10, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1500, 7000, 55, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 47, 10, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), 2200, 14000, 56, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 48, 10, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), 3000, 20000, 57, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 49, 10, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), 4200, 25000, 58, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 50, 10, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), 5100, 32000, 59, "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
