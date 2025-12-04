using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Addresses",
                newName: "Postcode");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Addresses",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Postcode",
                table: "Addresses",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Addresses",
                newName: "FirstName");
        }
    }
}
