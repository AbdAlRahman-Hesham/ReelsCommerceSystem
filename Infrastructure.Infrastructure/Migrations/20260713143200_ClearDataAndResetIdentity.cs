using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ClearDataAndResetIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. Disable all foreign key constraints (safety net — delete order below is correct on its own)
            migrationBuilder.Sql("EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");

            // 2. Delete data — ordered children before parents to respect all FK constraints
            //    Keepers: Admins, ProductCategory, ProductColor, ProductSize, RejectionReasons, Roles, RoleClaims, Interests, ShippingCompanies

            // ── Phase 1: Leaf tables (no other deleted table depends on them) ──

            // Reel domain leaves
            migrationBuilder.Sql("DELETE FROM [ReelCommentReplyLoves]");
            migrationBuilder.Sql("DELETE FROM [ReelCommentLove]");
            migrationBuilder.Sql("DELETE FROM [UserReelLike]");
            migrationBuilder.Sql("DELETE FROM [UserReelShares]");
            migrationBuilder.Sql("DELETE FROM [UserReelView]");

            // Product domain leaves
            migrationBuilder.Sql("DELETE FROM [ProductImage]");
            migrationBuilder.Sql("DELETE FROM [ProductInformation]");
            migrationBuilder.Sql("DELETE FROM [ProductSizeMapping]");
            migrationBuilder.Sql("DELETE FROM [UserProductView]");
            migrationBuilder.Sql("DELETE FROM [Reviews]");
            migrationBuilder.Sql("DELETE FROM [WishlistItems]");
            migrationBuilder.Sql("DELETE FROM [OfferProducts]");
            migrationBuilder.Sql("DELETE FROM [ProductReels]");

            // Community domain leaves
            migrationBuilder.Sql("DELETE FROM [PostCommentLike]");
            migrationBuilder.Sql("DELETE FROM [PostLike]");

            // Brand domain leaves
            migrationBuilder.Sql("DELETE FROM [BrandReviewDislikes]");
            migrationBuilder.Sql("DELETE FROM [BrandReviewLikes]");
            migrationBuilder.Sql("DELETE FROM [BrandSocialLinks]");
            migrationBuilder.Sql("DELETE FROM [BrandVerification]");
            migrationBuilder.Sql("DELETE FROM [UserBrandFollows]");

            // Chat domain leaves
            migrationBuilder.Sql("DELETE FROM [Messages]");

            // Order domain leaves
            migrationBuilder.Sql("DELETE FROM [OrderTrackings]");
            migrationBuilder.Sql("DELETE FROM [OrderProducts]");
            migrationBuilder.Sql("DELETE FROM [BrandSettlements]");
            migrationBuilder.Sql("DELETE FROM [ShippingSettlements]");
            migrationBuilder.Sql("DELETE FROM [WithdrawalRequests]");

            // Identity / User leaves
            migrationBuilder.Sql("DELETE FROM [UserInterests]");
            migrationBuilder.Sql("DELETE FROM [Addresses]");
            migrationBuilder.Sql("DELETE FROM [Notifications]");
            migrationBuilder.Sql("DELETE FROM [UserClaims]");
            migrationBuilder.Sql("DELETE FROM [UserRoles]");
            migrationBuilder.Sql("DELETE FROM [UserLogins]");
            migrationBuilder.Sql("DELETE FROM [UserTokens]");

            // Independent tables
            migrationBuilder.Sql("DELETE FROM [FinancialAuditLogs]");
            migrationBuilder.Sql("DELETE FROM [ContactMessages]");

            // ── Phase 2: Parents of Phase 1 ──

            // ReelCommentReplies → child: ReelCommentReplyLoves (Phase 1)
            migrationBuilder.Sql("DELETE FROM [ReelCommentReplies]");

            // ProductColorMapping → child: ProductSizeMapping (Phase 1)
            migrationBuilder.Sql("DELETE FROM [ProductColorMapping]");

            // PostComment → children: PostCommentLike (Phase 1), self-ref (bulk delete handles it)
            migrationBuilder.Sql("DELETE FROM [PostComment]");

            // BrandReview → children: BrandReviewDislikes, BrandReviewLikes (Phase 1)
            migrationBuilder.Sql("DELETE FROM [BrandReview]");

            // Offers → child: OfferProducts (Phase 1); FK to Brands (Restrict) — Brands not yet deleted
            migrationBuilder.Sql("DELETE FROM [Offers]");

            // ChatRooms → child: Messages (Phase 1); FK to Users (Restrict) — Users not yet deleted
            migrationBuilder.Sql("DELETE FROM [ChatRooms]");

            // ── Phase 3: Parents of Phase 2 ──

            // ReelComment → children: ReelCommentLove (Phase 1), ReelCommentReplies (Phase 2); FK to Users (Restrict)
            migrationBuilder.Sql("DELETE FROM [ReelComment]");

            // CommunityPost → children: PostComment (Phase 2), PostLike (Phase 1); FK to Brands (NoAction)
            migrationBuilder.Sql("DELETE FROM [CommunityPost]");

            // ── Phase 4: Parents of Phase 3 ──

            // Reels → children: ReelComment (Phase 3), UserReelLike/Shares/View (Phase 1), ProductReels (Phase 1); FK to Brands (NoAction)
            migrationBuilder.Sql("DELETE FROM [Reels]");

            // Products → children: ProductImage, ProductInformation, ProductColorMapping, UserProductView, Reviews, WishlistItems, OfferProducts, OrderProducts, ProductReels (Phases 1-2); FK to Brands (Cascade)
            migrationBuilder.Sql("DELETE FROM [Products]");

            // Orders → children: OrderTrackings, OrderProducts, BrandSettlements, ShippingSettlements (Phase 1); FK to Users (NoAction), DiscountCodes (Restrict)
            migrationBuilder.Sql("DELETE FROM [Orders]");

            // ── Phase 5: Parents of Phase 4 ──

            // DiscountCodes → parent was Orders (Restrict); Orders now deleted
            migrationBuilder.Sql("DELETE FROM [DiscountCodes]");

            // ── Phase 6: Parents of Phase 5 ──

            // Brands → children: BrandReview, BrandSocialLinks, BrandVerification, UserBrandFollows, CommunityPost, Offers, OrderProducts, BrandSettlements, WithdrawalRequests, Products, Reels, PostComment, PostCommentLike, PostLike (Phases 1-5); FK to Users (NoAction)
            migrationBuilder.Sql("DELETE FROM [Brands]");

            // ── Phase 7: Root table (all dependents removed) ──

            // Users → all child tables deleted in Phases 1-6
            migrationBuilder.Sql("DELETE FROM [Users]");

            // 3. Reset IDENTITY counters (next ID will be 1) — only for tables with int IDENTITY columns
            migrationBuilder.Sql("DBCC CHECKIDENT ('UserClaims', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Addresses', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Notifications', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Brands', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('BrandReview', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('BrandReviewLikes', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('BrandReviewDislikes', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('BrandVerification', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('BrandSocialLinks', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('UserBrandFollows', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Products', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ProductImage', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ProductInformation', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ProductColorMapping', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ProductSizeMapping', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('UserProductView', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ProductReels', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Reviews', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Orders', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('OrderProducts', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('OrderTrackings', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('DiscountCodes', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('WishlistItems', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Offers', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Reels', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ReelComment', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ReelCommentLove', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ReelCommentReplies', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ReelCommentReplyLoves', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('UserReelLike', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('UserReelShares', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('UserReelView', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ChatRooms', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('Messages', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('CommunityPost', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('PostComment', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('PostCommentLike', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('PostLike', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('BrandSettlements', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ShippingSettlements', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('WithdrawalRequests', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('FinancialAuditLogs', RESEED, 0)");
            migrationBuilder.Sql("DBCC CHECKIDENT ('ContactMessages', RESEED, 0)");

            // 4. Re-enable all foreign key constraints
            migrationBuilder.Sql("EXEC sp_MSforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Data deletion is not reversible
        }
    }
}
