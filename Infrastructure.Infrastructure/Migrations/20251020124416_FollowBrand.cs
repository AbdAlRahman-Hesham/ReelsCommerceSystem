using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FollowBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBrandFollow_Brands_BrandId",
                table: "UserBrandFollow");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBrandFollow_Users_UserId",
                table: "UserBrandFollow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBrandFollow",
                table: "UserBrandFollow");

            migrationBuilder.RenameTable(
                name: "UserBrandFollow",
                newName: "UserBrandFollows");

            migrationBuilder.RenameIndex(
                name: "IX_UserBrandFollow_UserId",
                table: "UserBrandFollows",
                newName: "IX_UserBrandFollows_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserBrandFollow_BrandId",
                table: "UserBrandFollows",
                newName: "IX_UserBrandFollows_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBrandFollows",
                table: "UserBrandFollows",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBrandFollows_Brands_BrandId",
                table: "UserBrandFollows",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBrandFollows_Users_UserId",
                table: "UserBrandFollows",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBrandFollows_Brands_BrandId",
                table: "UserBrandFollows");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBrandFollows_Users_UserId",
                table: "UserBrandFollows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBrandFollows",
                table: "UserBrandFollows");

            migrationBuilder.RenameTable(
                name: "UserBrandFollows",
                newName: "UserBrandFollow");

            migrationBuilder.RenameIndex(
                name: "IX_UserBrandFollows_UserId",
                table: "UserBrandFollow",
                newName: "IX_UserBrandFollow_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserBrandFollows_BrandId",
                table: "UserBrandFollow",
                newName: "IX_UserBrandFollow_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBrandFollow",
                table: "UserBrandFollow",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBrandFollow_Brands_BrandId",
                table: "UserBrandFollow",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBrandFollow_Users_UserId",
                table: "UserBrandFollow",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
