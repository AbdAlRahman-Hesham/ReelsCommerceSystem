using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingViewsForReelId51 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserReelView",
                columns: new[] { "Id", "CreatedAt", "ReelId", "UpdatedAt", "UserId", "VideoDurationSeconds", "WatchedDurationSeconds" },
                values: new object[,]
                {
                    { 61, new DateTime(2026, 1, 3, 10, 12, 15, 0, DateTimeKind.Utc), 51, new DateTime(2026, 1, 3, 10, 12, 20, 0, DateTimeKind.Utc), "user1", 90, 68 },
                    { 62, new DateTime(2026, 1, 5, 13, 22, 41, 0, DateTimeKind.Utc), 51, new DateTime(2026, 1, 5, 13, 22, 47, 0, DateTimeKind.Utc), "user2", 90, 84 },
                    { 63, new DateTime(2026, 1, 8, 16, 40, 3, 0, DateTimeKind.Utc), 51, new DateTime(2026, 1, 8, 16, 40, 9, 0, DateTimeKind.Utc), "user3", 90, 55 },
                    { 64, new DateTime(2026, 2, 2, 9, 14, 25, 0, DateTimeKind.Utc), 51, new DateTime(2026, 2, 2, 9, 14, 30, 0, DateTimeKind.Utc), "user4", 90, 77 },
                    { 65, new DateTime(2026, 2, 6, 11, 44, 10, 0, DateTimeKind.Utc), 51, new DateTime(2026, 2, 6, 11, 44, 15, 0, DateTimeKind.Utc), "user5", 90, 81 },
                    { 66, new DateTime(2026, 2, 11, 18, 3, 39, 0, DateTimeKind.Utc), 51, new DateTime(2026, 2, 11, 18, 3, 46, 0, DateTimeKind.Utc), "user6", 90, 49 },
                    { 67, new DateTime(2026, 3, 1, 8, 25, 55, 0, DateTimeKind.Utc), 51, new DateTime(2026, 3, 1, 8, 26, 1, 0, DateTimeKind.Utc), "user7", 90, 90 },
                    { 68, new DateTime(2026, 3, 4, 12, 18, 43, 0, DateTimeKind.Utc), 51, new DateTime(2026, 3, 4, 12, 18, 48, 0, DateTimeKind.Utc), "user8", 90, 61 },
                    { 69, new DateTime(2026, 3, 9, 15, 52, 16, 0, DateTimeKind.Utc), 51, new DateTime(2026, 3, 9, 15, 52, 22, 0, DateTimeKind.Utc), "user9", 90, 73 },
                    { 70, new DateTime(2026, 4, 2, 10, 33, 9, 0, DateTimeKind.Utc), 51, new DateTime(2026, 4, 2, 10, 33, 15, 0, DateTimeKind.Utc), "user10", 90, 86 },
                    { 71, new DateTime(2026, 4, 7, 14, 28, 34, 0, DateTimeKind.Utc), 51, new DateTime(2026, 4, 7, 14, 28, 39, 0, DateTimeKind.Utc), "6031f4a7-b9f6-4246-8a42-b283e686b924", 90, 44 },
                    { 72, new DateTime(2026, 4, 10, 17, 19, 20, 0, DateTimeKind.Utc), 51, new DateTime(2026, 4, 10, 17, 19, 26, 0, DateTimeKind.Utc), "863f4ca1-c278-4f70-bae6-3d2f8756d1b8", 90, 79 },
                    { 73, new DateTime(2026, 5, 1, 9, 42, 55, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 1, 9, 43, 1, 0, DateTimeKind.Utc), "b044f332-fb0e-4534-aa99-95146799ce11", 90, 66 },
                    { 74, new DateTime(2026, 5, 3, 11, 21, 17, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 3, 11, 21, 22, 0, DateTimeKind.Utc), "e18e137f-7c29-4001-b83e-a208d829b922", 90, 88 },
                    { 75, new DateTime(2026, 5, 6, 13, 5, 31, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 6, 13, 5, 37, 0, DateTimeKind.Utc), "5dc249b0-0e39-4115-8783-a72f4853769f", 90, 59 },
                    { 76, new DateTime(2026, 5, 8, 15, 44, 12, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 8, 15, 44, 18, 0, DateTimeKind.Utc), "a1b093c9-407d-469a-b627-560cc17bc58b", 90, 83 },
                    { 77, new DateTime(2026, 5, 10, 18, 12, 47, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 10, 18, 12, 52, 0, DateTimeKind.Utc), "a29a661d-a579-460f-a6eb-3692308940fa", 90, 71 },
                    { 78, new DateTime(2026, 5, 12, 20, 3, 15, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 12, 20, 3, 20, 0, DateTimeKind.Utc), "cce0a80c-645f-4d41-9f76-c9257f5e8ca2", 90, 52 },
                    { 79, new DateTime(2026, 5, 14, 9, 35, 26, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 14, 9, 35, 31, 0, DateTimeKind.Utc), "80dae523-57bd-4001-8e49-49e706ddbf42", 90, 90 },
                    { 80, new DateTime(2026, 5, 16, 11, 48, 3, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 16, 11, 48, 8, 0, DateTimeKind.Utc), "9fe7187f-94ff-4066-adca-06c16f6a9354", 90, 74 },
                    { 81, new DateTime(2026, 5, 18, 14, 17, 55, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 18, 14, 18, 1, 0, DateTimeKind.Utc), "8cc53df0-2132-4049-891a-25685f28d239", 90, 63 },
                    { 82, new DateTime(2026, 5, 20, 16, 24, 42, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 20, 16, 24, 47, 0, DateTimeKind.Utc), "a4eed7dd-be40-4d0b-a09f-88ec773a2729", 90, 58 },
                    { 83, new DateTime(2026, 5, 22, 18, 39, 14, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 22, 18, 39, 19, 0, DateTimeKind.Utc), "30ffb205-5b5e-496a-b908-04503fef9536", 90, 81 },
                    { 84, new DateTime(2026, 5, 24, 20, 55, 36, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 24, 20, 55, 42, 0, DateTimeKind.Utc), "143bbea2-2c1c-4fde-a209-c3398e108114", 90, 46 },
                    { 85, new DateTime(2026, 5, 26, 8, 14, 59, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 26, 8, 15, 4, 0, DateTimeKind.Utc), "9c761ca5-4ac4-4b8c-8bc4-d9b39784bbab", 90, 69 },
                    { 86, new DateTime(2026, 5, 27, 10, 28, 17, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 27, 10, 28, 22, 0, DateTimeKind.Utc), "af7ca807-fa30-406a-856f-21a79c7a30df", 90, 88 },
                    { 87, new DateTime(2026, 5, 28, 12, 47, 44, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 28, 12, 47, 50, 0, DateTimeKind.Utc), "03e4e169-0421-4729-919c-5d0273a2c253", 90, 54 },
                    { 88, new DateTime(2026, 5, 28, 14, 13, 28, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 28, 14, 13, 34, 0, DateTimeKind.Utc), "289946f1-6c5b-440f-840a-3101e95bd08e", 90, 90 },
                    { 89, new DateTime(2026, 5, 29, 16, 35, 11, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 29, 16, 35, 16, 0, DateTimeKind.Utc), "4da22cf4-9b48-4a07-a289-5b8771ccbe31", 90, 77 },
                    { 90, new DateTime(2026, 5, 30, 18, 52, 49, 0, DateTimeKind.Utc), 51, new DateTime(2026, 5, 30, 18, 52, 54, 0, DateTimeKind.Utc), "464d46db-3dbb-4027-8522-dfd9e82a53a4", 90, 61 },
                    { 91, new DateTime(2026, 6, 1, 9, 11, 15, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 1, 9, 11, 20, 0, DateTimeKind.Utc), "b1b8e459-8881-49c8-abdf-3b819ebc31e0", 90, 82 },
                    { 92, new DateTime(2026, 6, 2, 11, 24, 33, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 2, 11, 24, 39, 0, DateTimeKind.Utc), "80988744-94d6-4cf9-a072-67346dfa50c5", 90, 73 },
                    { 93, new DateTime(2026, 6, 3, 13, 37, 48, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 3, 13, 37, 54, 0, DateTimeKind.Utc), "bfa86d96-6038-47f8-b887-1f0dea200757", 90, 64 },
                    { 94, new DateTime(2026, 6, 4, 15, 45, 2, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 4, 15, 45, 7, 0, DateTimeKind.Utc), "94032bbb-163b-4261-b43e-bfcb1f68ba5a", 90, 58 },
                    { 95, new DateTime(2026, 6, 5, 17, 58, 14, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 5, 17, 58, 19, 0, DateTimeKind.Utc), "0f31a706-bda4-4089-9768-a71b5572b946", 90, 88 },
                    { 96, new DateTime(2026, 6, 6, 19, 12, 41, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 6, 19, 12, 46, 0, DateTimeKind.Utc), "4c6fe27a-e5a4-4125-887e-ed287cba033b", 90, 69 },
                    { 97, new DateTime(2026, 6, 7, 8, 29, 55, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 7, 8, 30, 1, 0, DateTimeKind.Utc), "2a4e3c3b-22dd-452a-bf43-0db970d623a4", 90, 76 },
                    { 98, new DateTime(2026, 6, 8, 10, 44, 27, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 8, 10, 44, 32, 0, DateTimeKind.Utc), "1b6383e9-832d-42d1-a705-2c7cbb26cf45", 90, 90 },
                    { 99, new DateTime(2026, 6, 9, 12, 57, 36, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 9, 12, 57, 42, 0, DateTimeKind.Utc), "b8948849-72cc-4a80-a2e5-1650207648c1", 90, 62 },
                    { 100, new DateTime(2026, 6, 10, 14, 16, 9, 0, DateTimeKind.Utc), 51, new DateTime(2026, 6, 10, 14, 16, 15, 0, DateTimeKind.Utc), "5b9f37a1-574f-4456-b080-c3db91697535", 90, 81 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
