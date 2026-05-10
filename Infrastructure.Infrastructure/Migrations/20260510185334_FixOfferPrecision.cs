using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixOfferPrecision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // This migration reconciles the model snapshot with the actual database schema.
            // Most columns and tables already exist in the database but were missing from the snapshot.
            
            // Apply precision fix for Offer.DiscountPercentage
            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPercentage",
                table: "Offers",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            // Re-syncing seed data for Admin users to be deterministic
            string[] adminIds = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            foreach (var id in adminIds)
            {
                migrationBuilder.UpdateData(
                    table: "Users",
                    keyColumn: "Id",
                    keyValue: id,
                    column: "CreatedAt",
                    value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPercentage",
                table: "Offers",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2,
                oldNullable: true);
        }
    }
}
