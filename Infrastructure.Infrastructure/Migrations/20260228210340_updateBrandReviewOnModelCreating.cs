using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateBrandReviewOnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BrandReview_BrandId",
                table: "BrandReview");

            migrationBuilder.CreateIndex(
                name: "IX_BrandReview_BrandId_UserId",
                table: "BrandReview",
                columns: new[] { "BrandId", "UserId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BrandReview_BrandId_UserId",
                table: "BrandReview");

            migrationBuilder.CreateIndex(
                name: "IX_BrandReview_BrandId",
                table: "BrandReview",
                column: "BrandId");
        }
    }
}
