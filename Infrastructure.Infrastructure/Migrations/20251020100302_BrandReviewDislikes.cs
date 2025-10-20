using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BrandReviewDislikes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandReviewDislikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandReviewDislikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrandReviewDislikes_BrandReview_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "BrandReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 25 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 2, 12 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 3,
                column: "NumOfLikes",
                value: 18);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 4,
                column: "NumOfLikes",
                value: 32);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 7,
                column: "NumOfLikes",
                value: 28);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 5, 3 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 35 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 2, 14 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 12,
                column: "NumOfLikes",
                value: 22);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 13,
                column: "NumOfLikes",
                value: 30);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 12 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 16,
                column: "NumOfLikes",
                value: 27);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 19,
                column: "NumOfLikes",
                value: 29);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 16 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 31 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 24,
                column: "NumOfLikes",
                value: 17);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 25,
                column: "NumOfLikes",
                value: 26);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 24 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 28,
                column: "NumOfLikes",
                value: 33);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 30,
                column: "NumOfLikes",
                value: 19);

            migrationBuilder.CreateIndex(
                name: "IX_BrandReviewDislikes_ReviewId",
                table: "BrandReviewDislikes",
                column: "ReviewId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandReviewDislikes");

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 3,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 4,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 7,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 12,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 13,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 16,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 19,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 24,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 25,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 28,
                column: "NumOfLikes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "NumOfDislikes", "NumOfLikes" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "BrandReview",
                keyColumn: "Id",
                keyValue: 30,
                column: "NumOfLikes",
                value: 0);
        }
    }
}
