using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BackfillBrandRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                UPDATE b
                SET
                    b.NumOfReviews = ISNULL(sub.Cnt, 0),
                    b.AverageRating = ISNULL(sub.Avg, 0.0)
                FROM Brands b
                LEFT JOIN (
                    SELECT
                        BrandId,
                        COUNT(*) AS Cnt,
                        AVG(CAST(Rating AS FLOAT)) AS Avg
                    FROM BrandReview
                    GROUP BY BrandId
                ) sub ON b.Id = sub.BrandId
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                UPDATE Brands
                SET NumOfReviews = 0, AverageRating = 0.0
            ");
        }
    }
}
