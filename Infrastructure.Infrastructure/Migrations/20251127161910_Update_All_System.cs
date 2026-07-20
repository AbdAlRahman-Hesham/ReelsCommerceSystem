using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_All_System : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlacklistedTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlacklistedTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerificationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReturnPolicyAsHtml = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HexCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Otp_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Otp_CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCustomizable = table.Column<bool>(type: "bit", nullable: false),
                    DiscountPercentage = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BrandReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    NumOfLikes = table.Column<int>(type: "int", nullable: false),
                    NumOfDislikes = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrandReview_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandReview_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeleviredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserBrandFollows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    FollowedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBrandFollows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBrandFollows_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBrandFollows_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInterests",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InterestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInterests", x => new { x.UserId, x.InterestId });
                    table.ForeignKey(
                        name: "FK_UserInterests_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInterests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AiChats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChatHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneratedImages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AiChats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AiChats_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AiChats_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductColorMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColorMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductColorMapping_ProductColor_ProductColorId",
                        column: x => x.ProductColorId,
                        principalTable: "ProductColor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductColorMapping_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInformation_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    NumOfLikes = table.Column<int>(type: "int", nullable: false),
                    NumOfWatches = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reels_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reels_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishlistItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistItems_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BrandReviewDislikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "BrandReviewLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandReviewLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrandReviewLikes_BrandReview_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "BrandReview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disputes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disputes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disputes_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disputes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    FinalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoreDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCustomized = table.Column<bool>(type: "bit", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSizeMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductColorMappingId = table.Column<int>(type: "int", nullable: false),
                    ProductSizeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizeMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSizeMapping_ProductColorMapping_ProductColorMappingId",
                        column: x => x.ProductColorMappingId,
                        principalTable: "ProductColorMapping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizeMapping_ProductSize_ProductSizeId",
                        column: x => x.ProductSizeId,
                        principalTable: "ProductSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "Description", "DisplayName", "LogoUrl", "ReturnPolicyAsHtml", "UpdatedAt", "VerificationStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "NovaWear creates sustainable fashion for modern lifestyles.", "NovaWear", "https://upload.wikimedia.org/wikipedia/commons/a/a9/Amazon_logo.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Verified" },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "TechEase designs smart accessories for a seamless daily life.", "TechEase", "https://upload.wikimedia.org/wikipedia/commons/0/08/Apple_logo_black.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Verified" },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Glowify offers natural skincare powered by modern innovation.", "Glowify", "https://upload.wikimedia.org/wikipedia/commons/f/fa/Google_logo.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pending" },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "UrbanFuel brings premium streetwear for active youth.", "UrbanFuel", "https://upload.wikimedia.org/wikipedia/commons/4/44/Microsoft_logo.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Verified" },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Zenora promotes wellness with premium lifestyle products.", "Zenora", "https://upload.wikimedia.org/wikipedia/commons/5/51/YouTube_logo.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Verified" },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "AeroFit crafts smart fitness gear for peak performance.", "AeroFit", "https://upload.wikimedia.org/wikipedia/commons/3/31/Reddit_Logo_Full_2021.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pending" },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "EcoNest builds eco-friendly home solutions for modern living.", "EcoNest", "https://upload.wikimedia.org/wikipedia/commons/2/2f/Instagram_logo_2016.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Verified" },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ByteWave delivers tech-driven accessories for everyday needs.", "ByteWave", "https://upload.wikimedia.org/wikipedia/commons/6/6f/Spotify_logo_with_text.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Verified" },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "PureGlow focuses on clean and ethical skincare essentials.", "PureGlow", "https://upload.wikimedia.org/wikipedia/commons/0/09/Twitter_bird_logo_2012.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pending" },
                    { 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trendora curates unique fashion items for trendsetters worldwide.", "Trendora", "https://upload.wikimedia.org/wikipedia/commons/0/02/TikTok_logo_text.svg", "<div style='color: #4B5563;'><h1 style='color: #1B2351; font-size: 2.5em; margin-bottom: 20px;'>Our Policy</h1><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>At Our Brand, our policy is to provide our clients with the best service possible. We are committed to ensuring customer satisfaction through quality, transparency, and continuous support.</p><p style='font-size: 1.1em; line-height: 1.6; margin-bottom: 15px;'>We believe in building trust with our clients by delivering consistent and reliable service at every stage.</p><div style='color: #1B2351; font-size: 1.2em; margin-top: 25px; margin-bottom: 10px;'>Connect with us:</div><ul style='list-style-type: disc; margin-left: 20px; padding-left: 0;'><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Facebook:</span><a href='https://facebook.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>facebook.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>Instagram:</span><a href='https://instagram.com/OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>instagram.com/OurBrandOfficial</a></li><li style='margin-bottom: 5px; font-size: 1.1em;'><span style='color: #4B5563;'>TikTok:</span><a href='https://tiktok.com/@OurBrandOfficial' target='_blank' style='color: #add8e6; text-decoration: underline;'>tiktok.com/@OurBrandOfficial</a></li></ul></div>", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Verified" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fashion", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Makeup", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Shoes", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Candles", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Perfumes", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Jewelry", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Accessories", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Travel", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bags", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handmade Crafts", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "ArName", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "ملابس", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Clothing", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, "أحذية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Footwear", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "إكسسوارات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Accessories", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "إلكترونيات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Electronics", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, "سماعات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Audio", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, "أجهزة قابلة للارتداء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Wearables", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, "العناية بالبشرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Skincare", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, "الملابس الخارجية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Outerwear", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, "لياقة بدنية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fitness", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, "العافية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Wellness", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, "منزل", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Home", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, "قرطاسية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Stationery", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, "معدات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Equipment", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, "ديكور منزلي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Home Decor", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, "بستنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gardening", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, "عبير المنزل", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Home Fragrance", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, "أجهزة منزلية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Appliances", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, "تخزين", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Storage", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, "مكتب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Office", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 20, "ملابس رياضية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Apparel", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ProductColor",
                columns: new[] { "Id", "ArName", "HexCode", "Name", "Quantity" },
                values: new object[,]
                {
                    { 1, "أحمر", "#FF0000", "Red", 0 },
                    { 2, "أزرق", "#0000FF", "Blue", 0 },
                    { 3, "أخضر", "#008000", "Green", 0 },
                    { 4, "أسود", "#000000", "Black", 0 },
                    { 5, "أبيض", "#FFFFFF", "White", 0 },
                    { 6, "أصفر", "#FFFF00", "Yellow", 0 },
                    { 7, "أرجواني", "#800080", "Purple", 0 },
                    { 8, "برتقالي", "#FFA500", "Orange", 0 },
                    { 9, "وردي", "#FFC0CB", "Pink", 0 },
                    { 10, "رمادي", "#808080", "Gray", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "Id", "Size" },
                values: new object[,]
                {
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "M" },
                    { 4, "L" },
                    { 5, "XL" },
                    { 6, "XXL" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "DisplayName", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageURL", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1", 0, "A1B2C3D4-E5F6-7890-ABCD-EF1234567890", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", "john.doe@example.com", true, "John", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "A1B2C3D4-E5F6-7890-ABCD-EF1234567890", false, "john.doe@example.com" },
                    { "user10", 0, "D0E1F2A3-B4C5-6789-4567-890123456789", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1996, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica White", "jessica.white@example.com", true, "Jessica", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "White", false, null, "JESSICA.WHITE@EXAMPLE.COM", "JESSICA.WHITE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "D0E1F2A3-B4C5-6789-4567-890123456789", false, "jessica.white@example.com" },
                    { "user2", 0, "B2C3D4E5-F6A7-8901-BCDE-F12345678901", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1992, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah Smith", "sarah.smith@example.com", true, "Sarah", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Smith", false, null, "SARAH.SMITH@EXAMPLE.COM", "SARAH.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "B2C3D4E5-F6A7-8901-BCDE-F12345678901", false, "sarah.smith@example.com" },
                    { "user3", 0, "C3D4E5F6-A7B8-9012-CDEF-123456789012", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1988, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mike Johnson", "mike.johnson@example.com", true, "Mike", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Johnson", false, null, "MIKE.JOHNSON@EXAMPLE.COM", "MIKE.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "C3D4E5F6-A7B8-9012-CDEF-123456789012", false, "mike.johnson@example.com" },
                    { "user4", 0, "D4E5F6A7-B8C9-0123-DEF1-234567890123", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily Davis", "emily.davis@example.com", true, "Emily", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Davis", false, null, "EMILY.DAVIS@EXAMPLE.COM", "EMILY.DAVIS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "D4E5F6A7-B8C9-0123-DEF1-234567890123", false, "emily.davis@example.com" },
                    { "user5", 0, "E5F6A7B8-C9D0-1234-EF12-345678901234", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1991, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Wilson", "david.wilson@example.com", true, "David", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Wilson", false, null, "DAVID.WILSON@EXAMPLE.COM", "DAVID.WILSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "E5F6A7B8-C9D0-1234-EF12-345678901234", false, "david.wilson@example.com" },
                    { "user6", 0, "F6A7B8C9-D0E1-2345-F123-456789012345", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1993, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa Brown", "lisa.brown@example.com", true, "Lisa", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Brown", false, null, "LISA.BROWN@EXAMPLE.COM", "LISA.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "F6A7B8C9-D0E1-2345-F123-456789012345", false, "lisa.brown@example.com" },
                    { "user7", 0, "A7B8C9D0-E1F2-3456-1234-567890123456", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1989, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Taylor", "james.taylor@example.com", true, "James", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Taylor", false, null, "JAMES.TAYLOR@EXAMPLE.COM", "JAMES.TAYLOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "A7B8C9D0-E1F2-3456-1234-567890123456", false, "james.taylor@example.com" },
                    { "user8", 0, "B8C9D0E1-F2A3-4567-2345-678901234567", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1994, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna Martinez", "anna.martinez@example.com", true, "Anna", "Female", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Martinez", false, null, "ANNA.MARTINEZ@EXAMPLE.COM", "ANNA.MARTINEZ@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "B8C9D0E1-F2A3-4567-2345-678901234567", false, "anna.martinez@example.com" },
                    { "user9", 0, "C9D0E1F2-A3B4-5678-3456-789012345678", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1987, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert Lee", "robert.lee@example.com", true, "Robert", "Male", "https://static.vecteezy.com/system/resources/previews/026/196/789/large_2x/profile-icon-symbol-design-illustration-vector.jpg", "Lee", false, null, "ROBERT.LEE@EXAMPLE.COM", "ROBERT.LEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6h6JxGGP8vGPLjYiXfKFoLjmJKM0xMvlJCX5+2CfJxF7qbJhWGLmF5V2I0KZgQ==", null, false, 2, "C9D0E1F2-A3B4-5678-3456-789012345678", false, "robert.lee@example.com" }
                });

            migrationBuilder.InsertData(
                table: "BrandReview",
                columns: new[] { "Id", "BrandId", "Comment", "CreatedAt", "NumOfDislikes", "NumOfLikes", "Rating", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Love their sustainable approach! The quality is amazing and the materials feel premium. Definitely worth the price.", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), 1, 25, 5, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), "user1" },
                    { 2, 1, "Good products but shipping took longer than expected. The eco-friendly packaging was a nice touch though.", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), 2, 12, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), "user2" },
                    { 3, 1, "The clothes are comfortable and stylish. Happy to support a brand that cares about the environment.", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), 0, 18, 5, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), "user3" },
                    { 4, 2, "Their charging dock is a game-changer! Charges all my devices simultaneously without overheating.", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), 0, 32, 5, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), "user4" },
                    { 5, 2, "Decent products but customer service could be better. Had an issue with my order resolution.", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Utc), 3, 8, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Utc), "user5" },
                    { 6, 2, "The smart accessories are innovative and well-designed. Perfect for my tech-heavy lifestyle.", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), 1, 15, 4, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), "user6" },
                    { 7, 3, "The serum transformed my skin! Natural ingredients actually work. My skin has never looked better.", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 28, 5, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "user7" },
                    { 8, 3, "Products are good but a bit pricey for the quantity. The results are noticeable though.", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Utc), 1, 10, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Utc), "user8" },
                    { 9, 3, "Had an allergic reaction to one product. Customer service was helpful with the return.", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Utc), 5, 3, 2, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Utc), "user9" },
                    { 10, 4, "Best streetwear brand out there! The hoodies are super comfortable and the designs are unique.", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), 1, 35, 5, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "user10" },
                    { 11, 4, "Quality is good but sizes run small. Make sure to order a size up for the perfect fit.", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 2, 14, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), "user1" },
                    { 12, 4, "Love their style! The jackets are my favorite - perfect for urban fashion enthusiasts.", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, 22, 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "user2" },
                    { 13, 5, "The yoga mat is incredible! Non-slip and eco-friendly. My practice has improved significantly.", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 0, 30, 5, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), "user3" },
                    { 14, 5, "Their wellness products create such a calming atmosphere at home. The diffuser is a must-have.", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 1, 12, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), "user4" },
                    { 15, 5, "Good quality products but the scent options are limited. Would love to see more variety.", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 2, 6, 3, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), "user5" },
                    { 16, 6, "The fitness tracker is accurate and durable. Battery life exceeds expectations.", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, 27, 5, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), "user6" },
                    { 17, 6, "Smart dumbbells are innovative but the app connectivity can be glitchy sometimes.", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 4, 5, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), "user7" },
                    { 18, 6, "Great fitness equipment for home workouts. The chest strap provides accurate heart rate data.", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 1, 11, 4, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), "user8" },
                    { 19, 7, "Love their eco-friendly approach! The air filter has improved our home air quality noticeably.", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 0, 29, 5, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), "user9" },
                    { 20, 7, "Sustainable products that actually work. The bamboo lamp is both functional and beautiful.", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 1, 16, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), "user10" },
                    { 21, 7, "Good concept but some products feel overpriced for what they offer.", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 3, 7, 3, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), "user1" },
                    { 22, 8, "Their tech accessories are top-notch! The charger is fast and reliable for all my devices.", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, 31, 5, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), "user2" },
                    { 23, 8, "Great mouse design but the battery life could be better. Comfortable for long work sessions.", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 2, 13, 4, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), "user3" },
                    { 24, 8, "The earbuds have clear sound quality. Perfect for both calls and music.", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 0, 17, 4, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), "user4" },
                    { 25, 9, "My skin has never been happier! The cleanser is gentle yet effective. Love the ethical approach.", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 0, 26, 5, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), "user5" },
                    { 26, 9, "Good skincare line but the moisturizer could be more hydrating for dry skin types.", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 2, 4, 3, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), "user6" },
                    { 27, 9, "The night cream works wonders! Woke up with glowing skin after just one use.", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 1, 24, 5, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), "user7" },
                    { 28, 10, "Fashion-forward pieces that always get compliments! The dress quality is exceptional.", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 0, 33, 5, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), "user8" },
                    { 29, 10, "Trendy designs but some items sell out too quickly. Wish they had better stock management.", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, 11, 4, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user9" },
                    { 30, 10, "Love their unique style! The handbag is my new favorite accessory for every occasion.", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Utc), 0, 19, 5, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Utc), "user10" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArDescription", "BrandId", "CategoryId", "CreatedAt", "Description", "DiscountPercentage", "IsCustomizable", "MediaUrl", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, 1, 1, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Breathable organic cotton tee for everyday comfort.", 10m, false, "Products/Brand1/EcoFlexT-Shirt.png", "EcoFlex T-Shirt", 180.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, null, 1, 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Stylish recycled denim jacket for a sustainable look.", 20m, true, "Products/Brand1/ReVibe Denim Jacket.jfif", "ReVibe Denim Jacket", 420.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, null, 1, 2, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Lightweight sneakers made from recycled fibers.", 30m, false, "Products/Brand1/EcoStride Sneakers.jfif", "EcoStride Sneakers", 360.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, null, 1, 1, new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Soft hoodie crafted from sustainable bamboo fabric.", 40m, true, "Products/Brand1/Bamboo Breeze Hoodie.png", "Bamboo Breeze Hoodie", 280.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, null, 1, 3, new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Eco-friendly tote bag with minimalist design.", null, false, "Products/Brand1/ReLeaf Tote Bag.jfif", "ReLeaf Tote Bag", 150.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, null, 1, 1, new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Comfortable pants made from recycled polyester.", null, false, "Products/Brand1/NatureFlow Pants.webp", "NatureFlow Pants", 310.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, null, 2, 4, new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Fast-charging braided USB-C cable with smart chip.", 10m, false, "Products/Brand2/SyncCharge Cable.jfif", "SyncCharge Cable", 180.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, null, 2, 4, new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Multi-device charging dock with wireless pad.", 20m, false, "Products/Brand2/SmartDock Pro.jfif", "SmartDock Pro", 420.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, null, 2, 5, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Noise-cancelling Bluetooth earbuds with 24h battery.", 30m, false, "Products/Brand2/AirPulse Earbuds.jfif", "AirPulse Earbuds", 540.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, null, 2, 3, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Smart magnetic car mount with auto-lock system.", 40m, false, "Products/Brand2/MagGrip Phone Mount.jfif", "MagGrip Phone Mount", 190.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, null, 2, 6, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Fitness smartwatch with heart-rate and sleep tracking.", null, false, "Products/Brand2/PulseTrack Watch.jfif", "PulseTrack Watch", 690.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, null, 2, 3, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), "MagSafe-compatible slim phone case.", null, false, "Products/Brand2/GlideCase.jfif", "GlideCase", 160.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, null, 3, 7, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Vitamin C serum that brightens and smooths skin.", 10m, false, "Products/Brand3/HydraBloom Serum.jpg", "HydraBloom Serum", 250.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, null, 3, 7, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Gentle cleanser with aloe and green tea.", 20m, false, "Products/Brand3/PureDew Cleanser.png", "PureDew Cleanser", 180.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, null, 3, 7, new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Hydrating toner that refines pores naturally.", 30m, false, "Products/Brand3/LumiMist Toner.webp", "LumiMist Toner", 210.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, null, 3, 7, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Rich moisturizer for overnight skin repair.", 40m, false, "Products/Brand3/Radiant Night Cream.webp", "Radiant Night Cream", 330.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, null, 3, 7, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Utc), "SPF 50 mineral sunscreen with lightweight feel.", null, false, "Products/Brand3/GlowShield Sunscreen.jpg", "GlowShield Sunscreen", 290.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, null, 3, 7, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), "All-day hydration for sensitive skin.", null, false, "Products/Brand3/SilkTouch Moisturizer.png", "SilkTouch Moisturizer", 270.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, null, 4, 1, new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Oversized hoodie with minimalist street-style logo.", 10m, false, "Products/Brand4/StreetCore Hoodie.png", "StreetCore Hoodie", 320.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 20, null, 4, 1, new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Slim-fit joggers for comfort and performance.", 20m, false, "Products/Brand4/UrbanFlex Joggers.png", "UrbanFlex Joggers", 270.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 21, null, 4, 2, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Modern street sneakers with breathable mesh upper.", 30m, false, "Products/Brand4/FuelRunner Sneakers.png", "FuelRunner Sneakers", 540.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 22, null, 4, 8, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Lightweight windbreaker with waterproof coating.", 40m, false, "Products/Brand4/CityWave Jacket.png", "CityWave Jacket", 620.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 23, null, 4, 3, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Classic snapback cap with embroidered logo.", null, false, "Products/Brand4/SnapEdge Cap.webp", "SnapEdge Cap", 180.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 24, null, 4, 1, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Soft cotton tee with subtle reflective branding.", null, false, "Products/Brand4/MetroLayer Tee.jpg", "MetroLayer Tee", 190.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 25, null, 5, 9, new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Premium non-slip yoga mat made with eco rubber.", 10m, false, "Products/Brand5/ZenMat.webp", "ZenMat Pro", 350.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 26, null, 5, 10, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Ultrasonic diffuser with ambient lighting.", 20m, false, "Products/Brand5/AromaBliss Diffuser.webp", "AromaBliss Diffuser", 290.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 27, null, 5, 11, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Soy candle infused with lavender and chamomile.", 30m, false, "Products/Brand5/CalmWave Candle.webp", "CalmWave Candle", 170.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 28, null, 5, 10, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Glass water bottle with bamboo lid and sleeve.", 40m, false, "Products/Brand5/Balance Bottle.webp", "Balance Bottle", 210.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 29, null, 5, 12, new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Guided journal for mindfulness and productivity.", null, false, "Products/Brand5/Focus Journal.webp", "Focus Journal", 150.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 30, null, 5, 10, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Natural lavender mist for better sleep.", null, false, "Products/Brand5/Serenity Pillow Spray.jpg", "Serenity Pillow Spray", 180.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 31, null, 6, 6, new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Fitness tracker with pulse and oxygen monitoring.", 10m, false, "Products/Brand6/AeroTrack Smart Band.png", "AeroTrack Smart Band", 540.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 32, null, 6, 13, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Adjustable dumbbells for home strength training.", 20m, false, "Products/Brand6/bowflex-dumbbells.jpg", "FlexCore Dumbbells", 720.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 33, null, 6, 3, new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Heart-rate strap compatible with popular apps.", 30m, false, "Products/Brand6/PulsePro Chest Strap.webp", "PulsePro Chest Strap", 210.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 34, null, 6, 9, new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), "High-density mat ideal for HIIT and yoga.", 40m, false, "Products/Brand6/AeroMat Trainer.webp", "AeroMat Trainer", 250.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 35, null, 6, 3, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Smart bottle that tracks hydration levels.", null, false, "Products/Brand6/HydraFuel Bottle.jfif", "HydraFuel Bottle", 170.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 36, null, 6, 14, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lightweight shorts with moisture-wicking tech.", null, false, "Products/Brand6/TrainLite Shorts.jpg", "TrainLite Shorts", 260.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 37, null, 7, 15, new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Bamboo desk lamp with rechargeable LED bulb.", 10m, false, "Products/Brand7/EcoGlow Lamp.webp", "EcoGlow Lamp", 250.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 38, null, 7, 11, new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Soft throw blanket made from recycled cotton.", 20m, false, "Products/Brand7/GreenWave Blanket.jfif", "GreenWave Blanket", 320.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 39, null, 7, 16, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Biodegradable planters perfect for indoor herbs.", 30m, false, "Products/Brand7/PlantPure Planter Set.jpg", "PlantPure Planter Set", 180.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 40, null, 7, 17, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Natural reed diffuser with citrus essential oils.", 40m, false, "Products/Brand7/EcoFresh Diffuser.webp", "EcoFresh Diffuser", 210.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 41, null, 7, 18, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Reusable air filter system for cleaner home air.", null, false, "Products/Brand7/PureBreeze Air Filter.webp", "PureBreeze Air Filter", 640.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 42, null, 7, 16, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Cork coasters made from renewable materials.", null, false, "Products/Brand7/Harmony Coasters.jfif", "Harmony Coasters", 160.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 43, null, 8, 4, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Utc), "High-speed GaN charger with dual USB-C output.", 10m, false, "Products/Brand8/VoltSync Charger.webp", "VoltSync Charger", 280.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 44, null, 8, 3, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Ergonomic wireless mouse with silent clicks.", 20m, false, "Products/Brand8/StreamPad Mouse.jpg", "StreamPad Mouse", 240.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 45, null, 8, 18, new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Shockproof case for portable SSDs.", 30m, false, "Products/Brand8/DataShell SSD Case.jpg", "DataShell SSD Case", 190.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 46, null, 8, 5, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Compact true wireless earbuds with clear audio.", 40m, false, "Products/Brand8/WavePods Mini.jpg", "WavePods Mini", 420.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 47, null, 8, 3, new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Utc), "AvailableColors-coded USB-C and Lightning cable pack.", null, false, "Products/Brand8/NeonLink Cable Set.webp", "NeonLink Cable Set", 160.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 48, null, 8, 19, new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Foldable aluminum laptop stand with cooling vents.", null, false, "Products/Brand8/GlideStand Laptop Dock.jpg", "GlideStand Laptop Dock", 360.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 49, null, 9, 7, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Refreshing foaming cleanser for daily use.", 10m, false, "Products/Brand9/AquaRenew Cleanser.png", "AquaRenew Cleanser", 180.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 50, null, 9, 7, new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Lightweight daily cream with niacinamide for radiant skin.", 20m, false, "Products/Brand9/BrightVeil Moisturizer.png", "BrightVeil Moisturizer", 220.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 51, null, 9, 7, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Detoxifying clay mask that purifies pores naturally.", 30m, false, "Products/Brand9/PureCure Mask.jpg", "PureCure Mask", 240.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 52, null, 9, 7, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Deep hydration serum enriched with hyaluronic acid.", 40m, false, "Products/Brand9/GlowHydra Serum.webp", "GlowHydra Serum", 390.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 53, null, 9, 7, new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Nourishing night cream with plant-based peptides.", null, false, "Products/Brand9/VitaLush Night Cream.webp", "VitaLush Night Cream", 260.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 54, null, 9, 7, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Balancing toner that smooths skin and reduces shine.", null, false, "Products/Brand9/FreshTone Toner.webp", "FreshTone Toner", 210.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 55, null, 10, 1, new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Chic velvet dress perfect for evening occasions.", 10m, false, "Products/Brand10/VelvetEdge Dress.webp", "VelvetEdge Dress", 780.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 56, null, 10, 8, new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Metallic cropped jacket for a bold statement look.", 20m, false, "Products/Brand10/UrbanGleam Jacket.jfif", "UrbanGleam Jacket", 650.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 57, null, 10, 2, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), "AvailableColors-shifting sneakers that stand out everywhere.", 30m, false, "Products/Brand10/ChromaSneak Shoes.webp", "ChromaSneak Shoes", 540.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 58, null, 10, 3, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Elegant faux-leather handbag with gold accents.", 40m, false, "Products/Brand10/LuxeLine Handbag.jfif", "LuxeLine Handbag", 720.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 59, null, 10, 1, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Trendy cropped top for modern streetwear style.", null, false, "Products/Brand10/PulseFit Crop Top.webp", "PulseFit Crop Top", 190.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 60, null, 10, 3, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Retro-futuristic shades with UV400 protection.", null, false, "Products/Brand10/NeoAura Sunglasses.jfif", "NeoAura Sunglasses", 350.00m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ProductInformation",
                columns: new[] { "Id", "ArGroup", "ArKey", "ArValue", "CreatedAt", "DisplayOrder", "Group", "Key", "ProductId", "Type", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { 1, "عام", "المادة", "قطن عضوي 100%", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "100% Organic Cotton" },
                    { 2, "الأبعاد", "الوزن", "150", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 1, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "150" },
                    { 3, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Sustainability", "Eco-Friendly", 1, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 4, "الاستدامة", "الشهادات", "معتمد GOTS، معيار المحتوى العضوي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Sustainability", "Certifications", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "GOTS Certified, Organic Content Standard" },
                    { 5, "العناية", "تعليمات العناية", "غسيل بالماكينة بماء بارد، تجفيف بالمجفف على حرارة منخفضة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, "Care", "Care Instructions", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Machine wash cold, Tumble dry low" },
                    { 6, "عام", "المادة", "دينيم معاد تدويره (85% قطن، 15% بوليستر)", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 2, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Recycled Denim (85% Cotton, 15% Polyester)" },
                    { 7, "الأبعاد", "الوزن", "800", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 2, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "800" },
                    { 8, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Sustainability", "Eco-Friendly", 2, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 9, "العناية", "العناية بالغسيل", "تنظيف جاف فقط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Care", "Wash Care", 2, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Dry clean only" },
                    { 10, "عام", "المادة", "بولي إيثيلين تيريفثاليت معاد تدويره، نعل مطاطي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 3, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Recycled PET, Rubber sole" },
                    { 11, "الأبعاد", "الوزن", "280", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 3, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "280" },
                    { 12, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Water Resistant", 3, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 13, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Sustainability", "Eco-Friendly", 3, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 14, "المواصفات", "طول الكابل", "1.5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Specifications", "Cable Length", 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1.5" },
                    { 15, "المميزات", "شحن سريع", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Fast Charging", 7, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 16, "تقني", "القدرة", "100", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Technical", "Wattage", 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "100" },
                    { 17, "الضمان", "فترة الضمان", "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Warranty", "Warranty Period", 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2" },
                    { 18, "البطارية", "عمر البطارية", "24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Battery", "Battery Life", 9, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "24" },
                    { 19, "المميزات", "إلغاء الضوضاء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Noise Cancellation", 9, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 20, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Waterproof", 9, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 21, "تقني", "إصدار البلوتوث", "5.2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Technical", "Bluetooth Version", 9, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "5.2" },
                    { 22, "الشاشة", "حجم الشاشة", "1.3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Display", "Screen Size", 11, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1.3" },
                    { 23, "الصحة", "مراقب معدل ضربات القلب", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Health", "Heart Rate Monitor", 11, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 24, "الصحة", "تتبع النوم", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Health", "Sleep Tracking", 11, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 25, "البطارية", "عمر البطارية", "7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Battery", "Battery Life", 11, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "7" },
                    { 26, "عام", "الحجم", "30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Volume", 13, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "30" },
                    { 27, "أخلاقي", "نباتي", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Ethical", "Vegan", 13, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 28, "أخلاقي", "خالي من القسوة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Ethical", "Cruelty Free", 13, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 29, "الاستخدام", "نوع البشرة", "جميع أنواع البشرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Usage", "Skin Type", 13, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All skin types" },
                    { 30, "المكونات", "المكونات الرئيسية", "فيتامين سي، حمض الهيالورونيك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, "Ingredients", "Key Ingredients", 13, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vitamin C, Hyaluronic Acid" },
                    { 31, "الحماية", "معامل الحماية", "50", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Protection", "SPF", 17, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "50" },
                    { 32, "عام", "الحجم", "50", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "General", "Volume", 17, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "50" },
                    { 33, "المكونات", "قائم على المعادن", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Ingredients", "Mineral Based", 17, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 34, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Water Resistant", 17, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 35, "عام", "المادة", "مزيج قطني", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 19, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Cotton Blend" },
                    { 36, "الأبعاد", "الوزن", "650", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 19, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "650" },
                    { 37, "عام", "النمط", "مقاس كبير", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "General", "Style", 19, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Oversized" },
                    { 38, "المميزات", "عدد الجيوب", "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Pocket Count", 19, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2" },
                    { 39, "عام", "المادة", "قماش شبكي، جلد صناعي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 21, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mesh, Synthetic Leather" },
                    { 40, "الأبعاد", "الوزن", "320", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 21, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "320" },
                    { 41, "المميزات", "منفس", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Breathable", 21, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 42, "المميزات", "نوع الإغلاق", "ربط بالرباط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Closure Type", 21, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lace-up" },
                    { 43, "الشاشة", "حجم الشاشة", "1.2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Display", "Screen Size", 31, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1.2" },
                    { 44, "البطارية", "عمر البطارية", "7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Battery", "Battery Life", 31, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "7" },
                    { 45, "الصحة", "مراقب معدل ضربات القلب", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Health", "Heart Rate Monitor", 31, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 46, "المميزات", "مقاوم للماء", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Features", "Waterproof", 31, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 47, "المواصفات", "نطاق الوزن", "25-5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Specifications", "Weight Range", 32, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "5-25" },
                    { 48, "المميزات", "قابل للتعديل", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Adjustable", 32, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 49, "عام", "المادة", "حديد، بلاستيك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "General", "Material", 32, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Steel, Plastic" },
                    { 50, "عام", "المادة", "خيزران", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 37, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bamboo" },
                    { 51, "الأبعاد", "الارتفاع", "35", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Height", 37, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "35" },
                    { 52, "المميزات", "قابل للتعتيم", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Dimmable", 37, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 53, "الاستدامة", "صديق للبيئة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Sustainability", "Eco-Friendly", 37, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 54, "تقني", "القدرة", "65", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Technical", "Wattage", 43, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "65" },
                    { 55, "المميزات", "المنافذ", "2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Features", "Ports", 43, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2" },
                    { 56, "المميزات", "شحن سريع", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Fast Charging", 43, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 57, "عام", "الحجم", "150", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Volume", 49, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "150" },
                    { 58, "أخلاقي", "نباتي", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Ethical", "Vegan", 49, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 59, "أخلاقي", "خالي من القسوة", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Ethical", "Cruelty Free", 49, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" },
                    { 60, "الاستخدام", "نوع البشرة", "جميع أنواع البشرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Usage", "Skin Type", 49, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All skin types" },
                    { 61, "عام", "المادة", "قطيفة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 55, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Velvet" },
                    { 62, "الأبعاد", "الطول", "110", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Length", 55, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "110" },
                    { 63, "المميزات", "البطانة", "ساتان", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Lining", 55, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Satin" },
                    { 64, "عام", "المادة", "صناعي متغير اللون", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "General", "Material", 57, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Color-shifting Synthetic" },
                    { 65, "الأبعاد", "الوزن", "350", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Dimensions", "Weight", 57, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "350" },
                    { 66, "المميزات", "تغير اللون", "نعم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Features", "Color Changing", 57, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "true" }
                });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "BrandId", "CreatedAt", "NumOfLikes", "NumOfWatches", "ProductId", "UpdatedAt", "VideoUrl" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1200, 8000, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 2, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2300, 15000, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 3, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1800, 11000, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 4, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2600, 20000, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 5, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3400, 25000, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 6, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 800, 5000, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 7, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6000, 95000, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 8, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 9000, 30000, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 9, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 15000, 35000, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 10, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 100000, 300000, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 11, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2000, 10000, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 12, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5000, 20000, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 13, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8000, 25000, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 14, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 10000, 40000, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 15, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 15000, 50000, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 16, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1700, 12000, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 17, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2500, 18000, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 18, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4000, 23000, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 19, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5200, 30000, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 20, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7500, 35000, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 21, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1300, 10000, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 22, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2000, 14000, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 23, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3600, 20000, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 24, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4500, 26000, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 25, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6000, 30000, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 26, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1800, 9000, 31, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 27, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2200, 15000, 32, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 28, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3500, 22000, 33, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 29, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4800, 28000, 34, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 30, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5200, 31000, 35, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 31, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1500, 7000, 37, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 32, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2100, 13000, 38, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 33, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2700, 20000, 39, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 34, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4000, 26000, 40, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 35, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5200, 32000, 41, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 36, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1800, 11000, 43, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 37, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2500, 16000, 44, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 38, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3900, 22000, 45, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 39, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4800, 27000, 46, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 40, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6500, 33000, 47, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 41, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1200, 8000, 49, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 42, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2000, 12000, 50, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 43, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2700, 18000, 51, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 44, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3600, 25000, 52, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 45, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4900, 30000, 53, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 46, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1500, 7000, 55, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 47, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2200, 14000, 56, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 48, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3000, 20000, 57, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 49, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4200, 25000, 58, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" },
                    { 50, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5100, 32000, 59, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://drive.google.com/file/d/1LClVnDoZRd4HGWi0Lt25ks6Av3r-XHxW/view?usp=drive_link" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "ProductId", "Rating", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 2, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 3, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 4, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 5, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 6, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 7, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 8, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 9, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 10, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 11, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 12, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 13, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 14, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 15, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 16, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 17, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 18, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 19, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 20, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 21, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 22, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 23, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 24, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 25, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 26, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 27, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 28, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 29, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 30, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 31, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 32, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 33, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 34, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 35, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 36, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 37, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 38, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 39, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 40, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 41, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 42, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 43, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 44, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 45, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 46, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 47, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 48, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 49, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 50, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 51, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 52, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 53, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 54, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 55, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 9, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 56, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 9, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 57, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 58, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 59, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 60, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 61, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 62, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 63, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 64, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 65, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 66, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 67, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 68, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 69, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 70, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 71, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 72, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 73, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 74, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 75, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 76, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 77, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 78, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 79, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 80, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 81, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 82, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 83, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 84, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 85, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 86, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 87, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 88, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 89, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 90, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 91, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 92, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 93, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 94, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 95, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 96, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 97, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 98, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 99, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 100, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 101, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 102, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 16, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 103, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 16, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 104, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 105, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 17, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 106, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 17, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 107, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 17, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 108, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 17, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 109, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 110, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 111, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 112, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 113, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 114, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 115, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 116, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 117, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 118, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 119, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 120, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 121, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 122, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 123, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 124, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 125, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 126, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 127, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 128, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 129, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 130, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 131, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 132, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 133, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 134, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 21, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 135, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 136, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 137, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 138, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 139, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 140, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 141, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 142, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 143, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 22, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 144, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 145, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 146, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 147, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 148, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 149, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 150, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 151, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 152, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 153, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 154, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 24, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 155, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 24, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 156, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 24, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 157, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 158, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 159, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 160, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 25, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 161, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 26, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 162, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 26, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 163, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 26, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 164, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 26, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 165, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 26, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 166, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 167, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 168, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 169, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 170, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 171, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 27, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 172, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 173, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 174, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 175, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 176, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 177, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 178, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 179, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 29, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 180, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 29, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 181, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 29, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 182, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 29, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 183, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 29, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 184, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 29, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 185, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 29, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 186, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 29, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 187, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 188, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 189, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 190, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 191, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 192, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 193, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 194, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 195, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 196, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 197, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 198, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 199, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 200, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 201, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 202, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 203, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 204, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 205, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 31, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 206, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 32, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 207, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 32, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 208, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 32, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 209, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 33, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 210, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 33, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 211, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 33, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 212, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 33, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 213, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 214, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 34, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 215, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 34, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 216, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 34, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 217, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 34, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 218, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 35, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 219, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 35, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 220, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 35, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 221, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 35, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 222, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 35, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 223, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 35, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 224, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 36, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 225, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 36, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 226, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 36, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 227, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 36, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 228, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 36, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 229, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 36, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 230, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 36, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 231, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 37, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 232, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 37, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 233, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 37, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 234, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 37, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 235, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 37, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 236, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 37, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 237, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 37, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 238, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 37, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 239, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 38, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 240, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 38, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 241, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 38, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 242, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 38, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 243, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 38, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 244, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 38, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 245, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 38, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 246, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 38, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 247, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 38, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 248, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 249, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 250, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 251, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 252, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 253, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 254, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 255, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 256, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 257, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 39, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 258, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 40, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 259, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 40, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 260, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 40, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 261, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 41, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 262, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 41, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 263, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 41, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 264, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 41, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 265, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 42, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 266, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 42, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 267, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 42, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 268, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 42, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 269, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 42, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 270, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 43, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 271, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 43, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 272, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 43, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 273, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 43, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 274, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 43, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 275, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 43, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 276, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 44, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 277, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 44, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 278, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 44, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 279, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 44, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 280, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 44, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 281, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 44, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 282, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 44, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 283, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 45, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 284, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 45, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 285, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 45, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 286, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 45, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 287, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 45, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 288, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 45, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 289, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 45, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 290, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 45, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 291, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 46, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 292, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 46, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 293, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 46, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 294, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 46, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 295, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 46, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 296, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 46, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 297, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 46, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 298, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 46, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 299, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 46, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 300, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 301, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 302, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 303, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 304, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 305, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 306, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 307, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 308, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 309, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 47, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 310, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 48, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 311, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 48, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 312, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 48, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 313, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 49, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 314, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 49, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 315, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 49, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 316, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 49, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 317, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 50, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 318, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 50, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 319, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 50, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 320, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 50, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 321, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 50, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 322, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 51, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 323, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 51, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 324, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 51, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 325, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 51, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 326, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 51, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 327, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 51, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 328, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 52, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 329, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 52, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 330, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 52, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 331, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 52, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 332, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 52, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 333, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 52, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 334, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 52, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 335, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 53, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 336, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 53, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 337, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 53, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 338, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 53, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 339, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 53, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 340, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 53, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 341, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 53, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 342, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 53, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 343, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 54, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 344, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 54, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 345, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 54, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 346, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 54, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 347, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 54, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 348, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 54, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 349, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 54, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 350, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 54, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 351, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 54, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 352, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 353, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 354, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 355, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 356, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 357, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 358, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 359, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 360, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 361, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 55, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 362, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 56, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { 363, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 56, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 364, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 56, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 365, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 57, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { 366, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 57, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 367, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 57, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 368, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 57, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 369, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 58, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { 370, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 58, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 371, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 58, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 372, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 58, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 373, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 58, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 374, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 59, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { 375, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 59, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 376, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 59, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 377, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 59, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 378, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 59, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 379, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 59, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 380, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { 381, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, 1, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { 382, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, 2, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { 383, "The product quality is good.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, 3, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { 384, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, 4, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { 385, "The product quality is excellent.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, 5, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { 386, "The product quality is average.", new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, 0, new DateTime(2025, 11, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "user7" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AiChats_ProductId",
                table: "AiChats",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AiChats_UserId",
                table: "AiChats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandReview_BrandId",
                table: "BrandReview",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandReview_UserId",
                table: "BrandReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandReviewDislikes_ReviewId",
                table: "BrandReviewDislikes",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandReviewLikes_ReviewId",
                table: "BrandReviewLikes",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Disputes_OrderId",
                table: "Disputes",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Disputes_UserId",
                table: "Disputes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_BrandId",
                table: "OrderProducts",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColorMapping_ProductColorId",
                table: "ProductColorMapping",
                column: "ProductColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColorMapping_ProductId",
                table: "ProductColorMapping",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInformation_ProductId",
                table: "ProductInformation",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeMapping_ProductColorMappingId",
                table: "ProductSizeMapping",
                column: "ProductColorMappingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeMapping_ProductSizeId",
                table: "ProductSizeMapping",
                column: "ProductSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reels_BrandId",
                table: "Reels",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Reels_ProductId",
                table: "Reels",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserBrandFollows_BrandId",
                table: "UserBrandFollows",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBrandFollows_UserId",
                table: "UserBrandFollows",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInterests_InterestId",
                table: "UserInterests",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_ProductId",
                table: "WishlistItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_UserId_ProductId",
                table: "WishlistItems",
                columns: new[] { "UserId", "ProductId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AiChats");

            migrationBuilder.DropTable(
                name: "BlacklistedTokens");

            migrationBuilder.DropTable(
                name: "BrandReviewDislikes");

            migrationBuilder.DropTable(
                name: "BrandReviewLikes");

            migrationBuilder.DropTable(
                name: "Disputes");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "ProductInformation");

            migrationBuilder.DropTable(
                name: "ProductSizeMapping");

            migrationBuilder.DropTable(
                name: "Reels");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserBrandFollows");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserInterests");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "WishlistItems");

            migrationBuilder.DropTable(
                name: "BrandReview");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductColorMapping");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ProductCategory");
        }
    }
}
