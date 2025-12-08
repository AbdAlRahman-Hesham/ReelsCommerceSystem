using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReelsSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumOfLikes",
                table: "Reels");

            migrationBuilder.DropColumn(
                name: "NumOfWatches",
                table: "Reels");

            migrationBuilder.CreateTable(
                name: "UserReelLike",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReelId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReelLike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReelLike_Reels_ReelId",
                        column: x => x.ReelId,
                        principalTable: "Reels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserReelLike_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserReelView",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReelId = table.Column<int>(type: "int", nullable: false),
                    WatchedDurationSeconds = table.Column<int>(type: "int", nullable: false),
                    VideoDurationSeconds = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReelView", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReelView_Reels_ReelId",
                        column: x => x.ReelId,
                        principalTable: "Reels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserReelView_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserReelLike_ReelId",
                table: "UserReelLike",
                column: "ReelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReelLike_UserId_ReelId",
                table: "UserReelLike",
                columns: new[] { "UserId", "ReelId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserReelView_ReelId",
                table: "UserReelView",
                column: "ReelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReelView_UserId",
                table: "UserReelView",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserReelLike");

            migrationBuilder.DropTable(
                name: "UserReelView");

            migrationBuilder.AddColumn<int>(
                name: "NumOfLikes",
                table: "Reels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfWatches",
                table: "Reels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 1200, 8000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2300, 15000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 1800, 11000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2600, 20000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 3400, 25000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 800, 5000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 6000, 95000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 9000, 30000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 15000, 35000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 100000, 300000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2000, 10000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 5000, 20000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 8000, 25000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 10000, 40000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 15000, 50000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 1700, 12000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2500, 18000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 4000, 23000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 5200, 30000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 7500, 35000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 1300, 10000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2000, 14000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 3600, 20000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 4500, 26000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 6000, 30000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 1800, 9000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2200, 15000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 3500, 22000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 4800, 28000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 5200, 31000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 1500, 7000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2100, 13000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2700, 20000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 4000, 26000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 5200, 32000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 1800, 11000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2500, 16000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 3900, 22000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 4800, 27000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 6500, 33000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 1200, 8000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2000, 12000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2700, 18000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 3600, 25000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 4900, 30000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 1500, 7000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 2200, 14000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 3000, 20000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 4200, 25000 });

            migrationBuilder.UpdateData(
                table: "Reels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "NumOfLikes", "NumOfWatches" },
                values: new object[] { 5100, 32000 });
        }
    }
}
