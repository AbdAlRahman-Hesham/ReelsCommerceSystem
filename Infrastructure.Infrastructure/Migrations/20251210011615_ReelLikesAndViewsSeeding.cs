using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReelLikesAndViewsSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserReelLike",
                columns: new[] { "Id", "CreatedAt", "ReelId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 2, 10, 12, 44, 0, DateTimeKind.Utc), 13, new DateTime(2025, 1, 2, 10, 12, 49, 0, DateTimeKind.Utc), "user3" },
                    { 2, new DateTime(2025, 1, 4, 14, 55, 20, 0, DateTimeKind.Utc), 27, new DateTime(2025, 1, 4, 14, 55, 25, 0, DateTimeKind.Utc), "user7" },
                    { 3, new DateTime(2025, 1, 6, 9, 11, 18, 0, DateTimeKind.Utc), 5, new DateTime(2025, 1, 6, 9, 11, 24, 0, DateTimeKind.Utc), "user1" },
                    { 4, new DateTime(2025, 1, 7, 16, 44, 39, 0, DateTimeKind.Utc), 32, new DateTime(2025, 1, 7, 16, 44, 45, 0, DateTimeKind.Utc), "user9" },
                    { 5, new DateTime(2025, 1, 8, 7, 32, 51, 0, DateTimeKind.Utc), 48, new DateTime(2025, 1, 8, 7, 32, 57, 0, DateTimeKind.Utc), "user4" },
                    { 6, new DateTime(2025, 1, 9, 11, 10, 12, 0, DateTimeKind.Utc), 2, new DateTime(2025, 1, 9, 11, 10, 17, 0, DateTimeKind.Utc), "user6" },
                    { 7, new DateTime(2025, 1, 10, 19, 27, 33, 0, DateTimeKind.Utc), 14, new DateTime(2025, 1, 10, 19, 27, 41, 0, DateTimeKind.Utc), "user2" },
                    { 8, new DateTime(2025, 1, 12, 6, 55, 21, 0, DateTimeKind.Utc), 45, new DateTime(2025, 1, 12, 6, 55, 28, 0, DateTimeKind.Utc), "user8" },
                    { 9, new DateTime(2025, 1, 13, 17, 13, 9, 0, DateTimeKind.Utc), 7, new DateTime(2025, 1, 13, 17, 13, 14, 0, DateTimeKind.Utc), "user5" },
                    { 10, new DateTime(2025, 1, 15, 12, 41, 55, 0, DateTimeKind.Utc), 22, new DateTime(2025, 1, 15, 12, 42, 2, 0, DateTimeKind.Utc), "user10" },
                    { 11, new DateTime(2025, 1, 16, 8, 11, 17, 0, DateTimeKind.Utc), 49, new DateTime(2025, 1, 16, 8, 11, 23, 0, DateTimeKind.Utc), "user3" },
                    { 12, new DateTime(2025, 1, 17, 20, 22, 43, 0, DateTimeKind.Utc), 36, new DateTime(2025, 1, 17, 20, 22, 49, 0, DateTimeKind.Utc), "user7" },
                    { 13, new DateTime(2025, 1, 18, 9, 59, 50, 0, DateTimeKind.Utc), 1, new DateTime(2025, 1, 18, 9, 59, 55, 0, DateTimeKind.Utc), "user6" },
                    { 14, new DateTime(2025, 1, 19, 15, 33, 14, 0, DateTimeKind.Utc), 28, new DateTime(2025, 1, 19, 15, 33, 19, 0, DateTimeKind.Utc), "user9" },
                    { 15, new DateTime(2025, 1, 20, 11, 24, 31, 0, DateTimeKind.Utc), 40, new DateTime(2025, 1, 20, 11, 24, 37, 0, DateTimeKind.Utc), "user2" },
                    { 16, new DateTime(2025, 1, 21, 18, 18, 47, 0, DateTimeKind.Utc), 16, new DateTime(2025, 1, 21, 18, 18, 51, 0, DateTimeKind.Utc), "user1" },
                    { 17, new DateTime(2025, 1, 22, 7, 25, 58, 0, DateTimeKind.Utc), 26, new DateTime(2025, 1, 22, 7, 26, 4, 0, DateTimeKind.Utc), "user5" },
                    { 18, new DateTime(2025, 1, 23, 10, 14, 13, 0, DateTimeKind.Utc), 11, new DateTime(2025, 1, 23, 10, 14, 18, 0, DateTimeKind.Utc), "user8" },
                    { 19, new DateTime(2025, 1, 24, 16, 52, 22, 0, DateTimeKind.Utc), 20, new DateTime(2025, 1, 24, 16, 52, 28, 0, DateTimeKind.Utc), "user10" },
                    { 20, new DateTime(2025, 1, 25, 12, 8, 43, 0, DateTimeKind.Utc), 33, new DateTime(2025, 1, 25, 12, 8, 50, 0, DateTimeKind.Utc), "user4" },
                    { 21, new DateTime(2025, 1, 26, 9, 57, 12, 0, DateTimeKind.Utc), 8, new DateTime(2025, 1, 26, 9, 57, 17, 0, DateTimeKind.Utc), "user7" },
                    { 22, new DateTime(2025, 1, 27, 17, 33, 29, 0, DateTimeKind.Utc), 31, new DateTime(2025, 1, 27, 17, 33, 35, 0, DateTimeKind.Utc), "user6" },
                    { 23, new DateTime(2025, 1, 28, 14, 19, 56, 0, DateTimeKind.Utc), 19, new DateTime(2025, 1, 28, 14, 20, 1, 0, DateTimeKind.Utc), "user3" },
                    { 24, new DateTime(2025, 1, 29, 10, 42, 24, 0, DateTimeKind.Utc), 25, new DateTime(2025, 1, 29, 10, 42, 30, 0, DateTimeKind.Utc), "user10" },
                    { 25, new DateTime(2025, 1, 30, 6, 28, 33, 0, DateTimeKind.Utc), 43, new DateTime(2025, 1, 30, 6, 28, 39, 0, DateTimeKind.Utc), "user2" },
                    { 26, new DateTime(2025, 1, 31, 20, 51, 45, 0, DateTimeKind.Utc), 9, new DateTime(2025, 1, 31, 20, 51, 51, 0, DateTimeKind.Utc), "user8" },
                    { 27, new DateTime(2025, 2, 1, 11, 6, 59, 0, DateTimeKind.Utc), 34, new DateTime(2025, 2, 1, 11, 7, 4, 0, DateTimeKind.Utc), "user5" },
                    { 28, new DateTime(2025, 2, 2, 14, 14, 12, 0, DateTimeKind.Utc), 18, new DateTime(2025, 2, 2, 14, 14, 16, 0, DateTimeKind.Utc), "user9" },
                    { 29, new DateTime(2025, 2, 3, 9, 25, 41, 0, DateTimeKind.Utc), 4, new DateTime(2025, 2, 3, 9, 25, 46, 0, DateTimeKind.Utc), "user4" },
                    { 30, new DateTime(2025, 2, 4, 15, 33, 27, 0, DateTimeKind.Utc), 41, new DateTime(2025, 2, 4, 15, 33, 33, 0, DateTimeKind.Utc), "user1" },
                    { 31, new DateTime(2025, 2, 5, 13, 44, 55, 0, DateTimeKind.Utc), 12, new DateTime(2025, 2, 5, 13, 45, 2, 0, DateTimeKind.Utc), "user6" },
                    { 32, new DateTime(2025, 2, 6, 7, 29, 42, 0, DateTimeKind.Utc), 30, new DateTime(2025, 2, 6, 7, 29, 49, 0, DateTimeKind.Utc), "user7" },
                    { 33, new DateTime(2025, 2, 7, 18, 21, 34, 0, DateTimeKind.Utc), 3, new DateTime(2025, 2, 7, 18, 21, 40, 0, DateTimeKind.Utc), "user10" },
                    { 34, new DateTime(2025, 2, 8, 10, 19, 9, 0, DateTimeKind.Utc), 35, new DateTime(2025, 2, 8, 10, 19, 14, 0, DateTimeKind.Utc), "user8" },
                    { 35, new DateTime(2025, 2, 9, 20, 58, 11, 0, DateTimeKind.Utc), 21, new DateTime(2025, 2, 9, 20, 58, 18, 0, DateTimeKind.Utc), "user3" },
                    { 36, new DateTime(2025, 2, 10, 8, 41, 33, 0, DateTimeKind.Utc), 17, new DateTime(2025, 2, 10, 8, 41, 38, 0, DateTimeKind.Utc), "user2" },
                    { 37, new DateTime(2025, 2, 11, 14, 30, 9, 0, DateTimeKind.Utc), 38, new DateTime(2025, 2, 11, 14, 30, 15, 0, DateTimeKind.Utc), "user5" },
                    { 38, new DateTime(2025, 2, 12, 9, 55, 58, 0, DateTimeKind.Utc), 42, new DateTime(2025, 2, 12, 9, 56, 4, 0, DateTimeKind.Utc), "user4" },
                    { 39, new DateTime(2025, 2, 13, 16, 12, 23, 0, DateTimeKind.Utc), 6, new DateTime(2025, 2, 13, 16, 12, 29, 0, DateTimeKind.Utc), "user9" },
                    { 40, new DateTime(2025, 2, 14, 19, 25, 18, 0, DateTimeKind.Utc), 23, new DateTime(2025, 2, 14, 19, 25, 22, 0, DateTimeKind.Utc), "user1" },
                    { 41, new DateTime(2025, 2, 15, 11, 48, 47, 0, DateTimeKind.Utc), 47, new DateTime(2025, 2, 15, 11, 48, 53, 0, DateTimeKind.Utc), "user7" },
                    { 42, new DateTime(2025, 2, 16, 15, 52, 14, 0, DateTimeKind.Utc), 24, new DateTime(2025, 2, 16, 15, 52, 20, 0, DateTimeKind.Utc), "user8" },
                    { 43, new DateTime(2025, 2, 17, 7, 39, 33, 0, DateTimeKind.Utc), 10, new DateTime(2025, 2, 17, 7, 39, 38, 0, DateTimeKind.Utc), "user4" },
                    { 44, new DateTime(2025, 2, 18, 17, 10, 41, 0, DateTimeKind.Utc), 29, new DateTime(2025, 2, 18, 17, 10, 47, 0, DateTimeKind.Utc), "user6" },
                    { 45, new DateTime(2025, 2, 19, 12, 28, 55, 0, DateTimeKind.Utc), 15, new DateTime(2025, 2, 19, 12, 29, 1, 0, DateTimeKind.Utc), "user5" },
                    { 46, new DateTime(2025, 2, 20, 14, 55, 11, 0, DateTimeKind.Utc), 44, new DateTime(2025, 2, 20, 14, 55, 18, 0, DateTimeKind.Utc), "user10" },
                    { 47, new DateTime(2025, 2, 21, 9, 22, 33, 0, DateTimeKind.Utc), 37, new DateTime(2025, 2, 21, 9, 22, 39, 0, DateTimeKind.Utc), "user2" },
                    { 48, new DateTime(2025, 2, 22, 13, 31, 12, 0, DateTimeKind.Utc), 46, new DateTime(2025, 2, 22, 13, 31, 18, 0, DateTimeKind.Utc), "user3" },
                    { 49, new DateTime(2025, 2, 23, 19, 14, 59, 0, DateTimeKind.Utc), 50, new DateTime(2025, 2, 23, 19, 15, 5, 0, DateTimeKind.Utc), "user9" },
                    { 50, new DateTime(2025, 2, 24, 8, 42, 54, 0, DateTimeKind.Utc), 39, new DateTime(2025, 2, 24, 8, 43, 0, 0, DateTimeKind.Utc), "user1" },
                    { 51, new DateTime(2025, 2, 25, 10, 55, 21, 0, DateTimeKind.Utc), 3, new DateTime(2025, 2, 25, 10, 55, 27, 0, DateTimeKind.Utc), "user6" },
                    { 52, new DateTime(2025, 2, 26, 18, 27, 11, 0, DateTimeKind.Utc), 12, new DateTime(2025, 2, 26, 18, 27, 17, 0, DateTimeKind.Utc), "user2" },
                    { 53, new DateTime(2025, 2, 27, 7, 17, 45, 0, DateTimeKind.Utc), 5, new DateTime(2025, 2, 27, 7, 17, 50, 0, DateTimeKind.Utc), "user7" },
                    { 54, new DateTime(2025, 2, 28, 13, 31, 59, 0, DateTimeKind.Utc), 18, new DateTime(2025, 2, 28, 13, 32, 5, 0, DateTimeKind.Utc), "user4" },
                    { 55, new DateTime(2025, 3, 1, 16, 40, 28, 0, DateTimeKind.Utc), 41, new DateTime(2025, 3, 1, 16, 40, 34, 0, DateTimeKind.Utc), "user5" },
                    { 56, new DateTime(2025, 3, 2, 9, 23, 44, 0, DateTimeKind.Utc), 7, new DateTime(2025, 3, 2, 9, 23, 50, 0, DateTimeKind.Utc), "user10" },
                    { 57, new DateTime(2025, 3, 3, 14, 14, 58, 0, DateTimeKind.Utc), 26, new DateTime(2025, 3, 3, 14, 15, 3, 0, DateTimeKind.Utc), "user8" },
                    { 58, new DateTime(2025, 3, 4, 18, 33, 18, 0, DateTimeKind.Utc), 9, new DateTime(2025, 3, 4, 18, 33, 24, 0, DateTimeKind.Utc), "user3" },
                    { 59, new DateTime(2025, 3, 5, 8, 56, 29, 0, DateTimeKind.Utc), 22, new DateTime(2025, 3, 5, 8, 56, 35, 0, DateTimeKind.Utc), "user4" },
                    { 60, new DateTime(2025, 3, 6, 12, 51, 28, 0, DateTimeKind.Utc), 9, new DateTime(2025, 3, 6, 12, 51, 34, 0, DateTimeKind.Utc), "user2" }
                });

            migrationBuilder.InsertData(
                table: "UserReelView",
                columns: new[] { "Id", "CreatedAt", "ReelId", "UpdatedAt", "UserId", "VideoDurationSeconds", "WatchedDurationSeconds" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 3, 9, 14, 22, 0, DateTimeKind.Utc), 12, new DateTime(2025, 1, 3, 9, 14, 31, 0, DateTimeKind.Utc), "user4", 80, 44 },
                    { 2, new DateTime(2025, 1, 5, 11, 22, 10, 0, DateTimeKind.Utc), 7, new DateTime(2025, 1, 5, 11, 22, 15, 0, DateTimeKind.Utc), "user1", 120, 61 },
                    { 3, new DateTime(2025, 1, 8, 14, 45, 51, 0, DateTimeKind.Utc), 25, new DateTime(2025, 1, 8, 14, 45, 56, 0, DateTimeKind.Utc), "user9", 55, 20 },
                    { 4, new DateTime(2025, 1, 11, 16, 20, 12, 0, DateTimeKind.Utc), 3, new DateTime(2025, 1, 11, 16, 20, 19, 0, DateTimeKind.Utc), "user3", 130, 78 },
                    { 5, new DateTime(2025, 1, 13, 18, 2, 44, 0, DateTimeKind.Utc), 31, new DateTime(2025, 1, 13, 18, 2, 47, 0, DateTimeKind.Utc), "user8", 70, 16 },
                    { 6, new DateTime(2025, 1, 14, 7, 18, 33, 0, DateTimeKind.Utc), 19, new DateTime(2025, 1, 14, 7, 18, 40, 0, DateTimeKind.Utc), "user7", 150, 93 },
                    { 7, new DateTime(2025, 1, 15, 9, 59, 28, 0, DateTimeKind.Utc), 8, new DateTime(2025, 1, 15, 9, 59, 33, 0, DateTimeKind.Utc), "user2", 44, 27 },
                    { 8, new DateTime(2025, 1, 17, 11, 44, 51, 0, DateTimeKind.Utc), 44, new DateTime(2025, 1, 17, 11, 44, 57, 0, DateTimeKind.Utc), "user6", 90, 36 },
                    { 9, new DateTime(2025, 1, 18, 13, 26, 11, 0, DateTimeKind.Utc), 15, new DateTime(2025, 1, 18, 13, 26, 18, 0, DateTimeKind.Utc), "user5", 100, 55 },
                    { 10, new DateTime(2025, 1, 20, 15, 10, 5, 0, DateTimeKind.Utc), 50, new DateTime(2025, 1, 20, 15, 10, 8, 0, DateTimeKind.Utc), "user10", 140, 88 },
                    { 11, new DateTime(2025, 1, 22, 9, 41, 39, 0, DateTimeKind.Utc), 18, new DateTime(2025, 1, 22, 9, 41, 44, 0, DateTimeKind.Utc), "user3", 90, 41 },
                    { 12, new DateTime(2025, 1, 23, 12, 27, 17, 0, DateTimeKind.Utc), 4, new DateTime(2025, 1, 23, 12, 27, 19, 0, DateTimeKind.Utc), "user2", 110, 66 },
                    { 13, new DateTime(2025, 1, 24, 14, 55, 9, 0, DateTimeKind.Utc), 36, new DateTime(2025, 1, 24, 14, 55, 16, 0, DateTimeKind.Utc), "user4", 60, 22 },
                    { 14, new DateTime(2025, 1, 25, 16, 33, 44, 0, DateTimeKind.Utc), 10, new DateTime(2025, 1, 25, 16, 33, 50, 0, DateTimeKind.Utc), "user7", 120, 80 },
                    { 15, new DateTime(2025, 1, 27, 18, 14, 29, 0, DateTimeKind.Utc), 27, new DateTime(2025, 1, 27, 18, 14, 32, 0, DateTimeKind.Utc), "user1", 40, 13 },
                    { 16, new DateTime(2025, 1, 28, 7, 21, 58, 0, DateTimeKind.Utc), 5, new DateTime(2025, 1, 28, 7, 22, 4, 0, DateTimeKind.Utc), "user6", 77, 34 },
                    { 17, new DateTime(2025, 1, 29, 10, 49, 41, 0, DateTimeKind.Utc), 48, new DateTime(2025, 1, 29, 10, 49, 45, 0, DateTimeKind.Utc), "user9", 117, 59 },
                    { 18, new DateTime(2025, 1, 30, 11, 56, 12, 0, DateTimeKind.Utc), 23, new DateTime(2025, 1, 30, 11, 56, 19, 0, DateTimeKind.Utc), "user10", 130, 71 },
                    { 19, new DateTime(2025, 2, 1, 8, 15, 55, 0, DateTimeKind.Utc), 1, new DateTime(2025, 2, 1, 8, 16, 1, 0, DateTimeKind.Utc), "user8", 80, 26 },
                    { 20, new DateTime(2025, 2, 2, 9, 37, 26, 0, DateTimeKind.Utc), 22, new DateTime(2025, 2, 2, 9, 37, 32, 0, DateTimeKind.Utc), "user5", 104, 52 },
                    { 21, new DateTime(2025, 2, 3, 12, 58, 51, 0, DateTimeKind.Utc), 17, new DateTime(2025, 2, 3, 12, 58, 55, 0, DateTimeKind.Utc), "user1", 90, 47 },
                    { 22, new DateTime(2025, 2, 4, 15, 19, 33, 0, DateTimeKind.Utc), 29, new DateTime(2025, 2, 4, 15, 19, 37, 0, DateTimeKind.Utc), "user3", 95, 32 },
                    { 23, new DateTime(2025, 2, 5, 17, 40, 28, 0, DateTimeKind.Utc), 49, new DateTime(2025, 2, 5, 17, 40, 33, 0, DateTimeKind.Utc), "user5", 150, 89 },
                    { 24, new DateTime(2025, 2, 6, 9, 22, 14, 0, DateTimeKind.Utc), 11, new DateTime(2025, 2, 6, 9, 22, 20, 0, DateTimeKind.Utc), "user10", 70, 18 },
                    { 25, new DateTime(2025, 2, 7, 11, 34, 59, 0, DateTimeKind.Utc), 32, new DateTime(2025, 2, 7, 11, 35, 6, 0, DateTimeKind.Utc), "user4", 130, 70 },
                    { 26, new DateTime(2025, 2, 8, 13, 46, 42, 0, DateTimeKind.Utc), 45, new DateTime(2025, 2, 8, 13, 46, 49, 0, DateTimeKind.Utc), "user6", 75, 29 },
                    { 27, new DateTime(2025, 2, 9, 15, 58, 30, 0, DateTimeKind.Utc), 9, new DateTime(2025, 2, 9, 15, 58, 37, 0, DateTimeKind.Utc), "user7", 110, 55 },
                    { 28, new DateTime(2025, 2, 10, 18, 10, 25, 0, DateTimeKind.Utc), 6, new DateTime(2025, 2, 10, 18, 10, 30, 0, DateTimeKind.Utc), "user2", 60, 24 },
                    { 29, new DateTime(2025, 2, 11, 8, 21, 44, 0, DateTimeKind.Utc), 40, new DateTime(2025, 2, 11, 8, 21, 50, 0, DateTimeKind.Utc), "user8", 100, 39 },
                    { 30, new DateTime(2025, 2, 12, 10, 33, 19, 0, DateTimeKind.Utc), 28, new DateTime(2025, 2, 12, 10, 33, 26, 0, DateTimeKind.Utc), "user9", 140, 91 },
                    { 31, new DateTime(2025, 2, 13, 12, 44, 55, 0, DateTimeKind.Utc), 16, new DateTime(2025, 2, 13, 12, 45, 1, 0, DateTimeKind.Utc), "user3", 66, 30 },
                    { 32, new DateTime(2025, 2, 14, 14, 56, 37, 0, DateTimeKind.Utc), 34, new DateTime(2025, 2, 14, 14, 56, 43, 0, DateTimeKind.Utc), "user2", 120, 57 },
                    { 33, new DateTime(2025, 2, 15, 9, 11, 23, 0, DateTimeKind.Utc), 14, new DateTime(2025, 2, 15, 9, 11, 28, 0, DateTimeKind.Utc), "user1", 40, 11 },
                    { 34, new DateTime(2025, 2, 16, 11, 23, 46, 0, DateTimeKind.Utc), 39, new DateTime(2025, 2, 16, 11, 23, 52, 0, DateTimeKind.Utc), "user6", 130, 68 },
                    { 35, new DateTime(2025, 2, 17, 13, 35, 9, 0, DateTimeKind.Utc), 20, new DateTime(2025, 2, 17, 13, 35, 14, 0, DateTimeKind.Utc), "user4", 70, 17 },
                    { 36, new DateTime(2025, 2, 18, 16, 47, 50, 0, DateTimeKind.Utc), 2, new DateTime(2025, 2, 18, 16, 47, 56, 0, DateTimeKind.Utc), "user9", 90, 33 },
                    { 37, new DateTime(2025, 2, 19, 18, 59, 33, 0, DateTimeKind.Utc), 21, new DateTime(2025, 2, 19, 18, 59, 38, 0, DateTimeKind.Utc), "user4", 135, 77 },
                    { 38, new DateTime(2025, 2, 20, 8, 14, 11, 0, DateTimeKind.Utc), 47, new DateTime(2025, 2, 20, 8, 14, 18, 0, DateTimeKind.Utc), "user10", 90, 26 },
                    { 39, new DateTime(2025, 2, 21, 10, 26, 44, 0, DateTimeKind.Utc), 30, new DateTime(2025, 2, 21, 10, 26, 48, 0, DateTimeKind.Utc), "user7", 100, 45 },
                    { 40, new DateTime(2025, 2, 22, 12, 38, 52, 0, DateTimeKind.Utc), 35, new DateTime(2025, 2, 22, 12, 38, 59, 0, DateTimeKind.Utc), "user5", 150, 86 },
                    { 41, new DateTime(2025, 2, 23, 14, 50, 41, 0, DateTimeKind.Utc), 26, new DateTime(2025, 2, 23, 14, 50, 47, 0, DateTimeKind.Utc), "user3", 75, 28 },
                    { 42, new DateTime(2025, 2, 24, 9, 1, 33, 0, DateTimeKind.Utc), 38, new DateTime(2025, 2, 24, 9, 1, 37, 0, DateTimeKind.Utc), "user8", 90, 53 },
                    { 43, new DateTime(2025, 2, 25, 11, 13, 20, 0, DateTimeKind.Utc), 46, new DateTime(2025, 2, 25, 11, 13, 26, 0, DateTimeKind.Utc), "user2", 140, 71 },
                    { 44, new DateTime(2025, 2, 26, 13, 25, 12, 0, DateTimeKind.Utc), 41, new DateTime(2025, 2, 26, 13, 25, 16, 0, DateTimeKind.Utc), "user6", 70, 25 },
                    { 45, new DateTime(2025, 2, 27, 15, 37, 5, 0, DateTimeKind.Utc), 24, new DateTime(2025, 2, 27, 15, 37, 9, 0, DateTimeKind.Utc), "user1", 95, 49 },
                    { 46, new DateTime(2025, 2, 28, 17, 49, 52, 0, DateTimeKind.Utc), 43, new DateTime(2025, 2, 28, 17, 49, 58, 0, DateTimeKind.Utc), "user7", 145, 84 },
                    { 47, new DateTime(2025, 3, 1, 8, 4, 18, 0, DateTimeKind.Utc), 33, new DateTime(2025, 3, 1, 8, 4, 24, 0, DateTimeKind.Utc), "user9", 50, 15 },
                    { 48, new DateTime(2025, 3, 2, 10, 16, 47, 0, DateTimeKind.Utc), 42, new DateTime(2025, 3, 2, 10, 16, 52, 0, DateTimeKind.Utc), "user10", 120, 67 },
                    { 49, new DateTime(2025, 3, 3, 12, 28, 39, 0, DateTimeKind.Utc), 37, new DateTime(2025, 3, 3, 12, 28, 45, 0, DateTimeKind.Utc), "user4", 60, 21 },
                    { 50, new DateTime(2025, 3, 4, 14, 40, 22, 0, DateTimeKind.Utc), 13, new DateTime(2025, 3, 4, 14, 40, 27, 0, DateTimeKind.Utc), "user5", 130, 72 },
                    { 51, new DateTime(2025, 3, 5, 16, 52, 11, 0, DateTimeKind.Utc), 6, new DateTime(2025, 3, 5, 16, 52, 14, 0, DateTimeKind.Utc), "user7", 90, 39 },
                    { 52, new DateTime(2025, 3, 6, 9, 3, 44, 0, DateTimeKind.Utc), 4, new DateTime(2025, 3, 6, 9, 3, 49, 0, DateTimeKind.Utc), "user6", 140, 91 },
                    { 53, new DateTime(2025, 3, 7, 11, 15, 26, 0, DateTimeKind.Utc), 7, new DateTime(2025, 3, 7, 11, 15, 32, 0, DateTimeKind.Utc), "user1", 100, 48 },
                    { 54, new DateTime(2025, 3, 8, 13, 27, 9, 0, DateTimeKind.Utc), 27, new DateTime(2025, 3, 8, 13, 27, 14, 0, DateTimeKind.Utc), "user3", 120, 63 },
                    { 55, new DateTime(2025, 3, 9, 15, 39, 52, 0, DateTimeKind.Utc), 12, new DateTime(2025, 3, 9, 15, 39, 57, 0, DateTimeKind.Utc), "user2", 160, 90 },
                    { 56, new DateTime(2025, 3, 10, 17, 51, 44, 0, DateTimeKind.Utc), 8, new DateTime(2025, 3, 10, 17, 51, 49, 0, DateTimeKind.Utc), "user10", 50, 12 },
                    { 57, new DateTime(2025, 3, 11, 8, 2, 33, 0, DateTimeKind.Utc), 17, new DateTime(2025, 3, 11, 8, 2, 39, 0, DateTimeKind.Utc), "user8", 70, 22 },
                    { 58, new DateTime(2025, 3, 12, 10, 14, 19, 0, DateTimeKind.Utc), 50, new DateTime(2025, 3, 12, 10, 14, 26, 0, DateTimeKind.Utc), "user5", 130, 77 },
                    { 59, new DateTime(2025, 3, 13, 12, 26, 57, 0, DateTimeKind.Utc), 19, new DateTime(2025, 3, 13, 12, 27, 2, 0, DateTimeKind.Utc), "user9", 90, 55 },
                    { 60, new DateTime(2025, 3, 14, 14, 38, 30, 0, DateTimeKind.Utc), 31, new DateTime(2025, 3, 14, 14, 38, 36, 0, DateTimeKind.Utc), "user4", 80, 35 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "UserReelLike",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "UserReelView",
                keyColumn: "Id",
                keyValue: 60);
        }
    }
}
