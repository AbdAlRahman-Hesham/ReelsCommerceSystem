using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditCommunityEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommunityPost_Users_UserId",
                table: "CommunityPost");

            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_Users_UserId",
                table: "PostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostCommentLike_Users_UserId",
                table: "PostCommentLike");

            migrationBuilder.DropTable(
                name: "UserPostLike");

            migrationBuilder.DropIndex(
                name: "IX_PostCommentLike_UserId_PostCommentId",
                table: "PostCommentLike");

            migrationBuilder.DropIndex(
                name: "IX_PostComment_UserId",
                table: "PostComment");

            migrationBuilder.DropIndex(
                name: "IX_CommunityPost_UserId",
                table: "CommunityPost");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PostCommentLike");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PostComment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CommunityPost");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "PostCommentLike",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "PostComment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "CommunityPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PostLike",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostLike_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostLike_CommunityPost_PostId",
                        column: x => x.PostId,
                        principalTable: "CommunityPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostCommentLike_BrandId_PostCommentId",
                table: "PostCommentLike",
                columns: new[] { "BrandId", "PostCommentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_BrandId",
                table: "PostComment",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPost_BrandId",
                table: "CommunityPost",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLike_BrandId_PostId",
                table: "PostLike",
                columns: new[] { "BrandId", "PostId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostLike_PostId",
                table: "PostLike",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityPost_Brands_BrandId",
                table: "CommunityPost",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_Brands_BrandId",
                table: "PostComment",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostCommentLike_Brands_BrandId",
                table: "PostCommentLike",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommunityPost_Brands_BrandId",
                table: "CommunityPost");

            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_Brands_BrandId",
                table: "PostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostCommentLike_Brands_BrandId",
                table: "PostCommentLike");

            migrationBuilder.DropTable(
                name: "PostLike");

            migrationBuilder.DropIndex(
                name: "IX_PostCommentLike_BrandId_PostCommentId",
                table: "PostCommentLike");

            migrationBuilder.DropIndex(
                name: "IX_PostComment_BrandId",
                table: "PostComment");

            migrationBuilder.DropIndex(
                name: "IX_CommunityPost_BrandId",
                table: "CommunityPost");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "PostCommentLike");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "PostComment");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "CommunityPost");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PostCommentLike",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PostComment",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CommunityPost",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "UserPostLike",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPostLike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPostLike_CommunityPost_PostId",
                        column: x => x.PostId,
                        principalTable: "CommunityPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPostLike_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostCommentLike_UserId_PostCommentId",
                table: "PostCommentLike",
                columns: new[] { "UserId", "PostCommentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_UserId",
                table: "PostComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityPost_UserId",
                table: "CommunityPost",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostLike_PostId",
                table: "UserPostLike",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostLike_UserId_PostId",
                table: "UserPostLike",
                columns: new[] { "UserId", "PostId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunityPost_Users_UserId",
                table: "CommunityPost",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_Users_UserId",
                table: "PostComment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostCommentLike_Users_UserId",
                table: "PostCommentLike",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
