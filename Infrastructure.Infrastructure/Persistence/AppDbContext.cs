using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ChatEntities;
using ReelsCommerceSystem.Domain.Entities.InterestEntities;
using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Domain.Entities.ShippingCompanyEntities;
using ReelsCommerceSystem.Domain.Entities.UserInterestEntities;
using ReelsCommerceSystem.Infrastructure.Persistence.DataSeeding;

namespace ReelsCommerceSystem.Infrastructure.Persistence;

public class AppDbContext :IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){ }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        optionsBuilder.ConfigureWarnings(w => w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.MultipleCollectionIncludeWarning)
            .Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       

        base.OnModelCreating(modelBuilder);


       


        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Entity<IdentityRole>(b =>
        {
            b.ToTable("Roles");
        });
        modelBuilder.Entity<User>(b =>
        {
            b.ToTable("Users");
            b.OwnsOne(u => u.Otp);
        });
        modelBuilder.Entity<Address>(b =>
        { b.ToTable("Addresses"); });
        modelBuilder.Entity<IdentityUserRole<string>>(b =>
        {
            b.ToTable("UserRoles");
        });
        modelBuilder.Entity<IdentityUserClaim<string>>(b =>
        {
            b.ToTable("UserClaims");
        });
        modelBuilder.Entity<IdentityUserLogin<string>>(b =>
        {
            b.ToTable("UserLogins");
        });
        modelBuilder.Entity<IdentityRoleClaim<string>>(b =>
        {
            b.ToTable("RoleClaims");
        }); 
        modelBuilder.Entity<IdentityUserToken<string>>(b =>
        {
            b.ToTable("UserTokens");
        });


        // ReelComment - FK على Reel مع Cascade
        modelBuilder.Entity<ReelComment>()
            .HasOne(rc => rc.Reel)
            .WithMany(r => r.ReelComments) // أو Navigation Property المناسب
            .HasForeignKey(rc => rc.ReelId)
            .OnDelete(DeleteBehavior.Cascade);

        // UserReelShare - FK على Reel مع Cascade
        modelBuilder.Entity<UserReelShare>()
            .HasOne(s => s.Reel)
            .WithMany(r => r.UserReelShares)
            .HasForeignKey(s => s.ReelId)
            .OnDelete(DeleteBehavior.Cascade);

        // UserReelShare - FK على User بدون Cascade
        modelBuilder.Entity<UserReelShare>()
            .HasOne(s => s.User)
            .WithMany(u => u.UserReelShares)
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // ReelComment - FK على User بدون Cascade
        modelBuilder.Entity<ReelComment>()
            .HasOne(rc => rc.User)
            .WithMany(u=>u.ReelComments) // بدون Navigation Property على User
            .HasForeignKey(rc => rc.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // ReelCommentLove - FK على ReelComment مع Cascade
        modelBuilder.Entity<ReelCommentLove>()
            .HasOne(rcl => rcl.ReelComment)
            .WithMany(rc => rc.Loves)
            .HasForeignKey(rcl => rcl.ReelCommentId)
            .OnDelete(DeleteBehavior.Cascade);

        // ReelCommentLove - FK على User بدون Cascade
        modelBuilder.Entity<ReelCommentLove>()
            .HasOne(rcl => rcl.User)
            .WithMany(u=>u.ReelCommentLoves)
            .HasForeignKey(rcl => rcl.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // منع تكرار Love لنفس Comment من نفس User
        modelBuilder.Entity<ReelCommentLove>()
            .HasIndex(rcl => new { rcl.ReelCommentId, rcl.UserId })
            .IsUnique();


        #region OfferProduct 
        // composite key
        modelBuilder.Entity<OfferProduct>()
            .HasKey(op => new { op.OfferId, op.ProductId });


        // one offer -> many products in mapping
        modelBuilder.Entity<OfferProduct>()
            .HasOne(op => op.Offer)
            .WithMany(o => o.OfferProducts)
            .HasForeignKey(op => op.OfferId);


        // one product -> many offers through mapping
        modelBuilder.Entity<OfferProduct>()
       .HasOne(op => op.Product)
       .WithMany(p => p.OfferProducts)
       .HasForeignKey(op => op.ProductId);


        // Offer -> Brand
        modelBuilder.Entity<Offer>()
            .HasOne(o => o.Brand)
            .WithMany(b => b.Offers)
            .HasForeignKey(o => o.BrandId)
            .OnDelete(DeleteBehavior.Restrict);


        #endregion

        modelBuilder.Entity<ReelCommentReply>()
             .HasOne(r => r.ParentComment)
              .WithMany(c => c.Replies)
              .HasForeignKey(r => r.ParentCommentId)
              .OnDelete(DeleteBehavior.Cascade);


          //love--->reply
        modelBuilder.Entity<ReelCommentReplyLove>()
           .HasOne(l => l.ReelCommentReply)
           .WithMany(r => r.Loves)
           .HasForeignKey(l => l.ReelCommentReplyId)
           .OnDelete(DeleteBehavior.Cascade);

        //user----->reelcommentreplylove
        modelBuilder.Entity<ReelCommentReplyLove>()
            .HasOne(l => l.User)
            .WithMany(u => u.reelCommentReplyLoves)
            .HasForeignKey(l => l.UserId)
            .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<ReelCommentReplyLove>()
          .HasIndex(l => new { l.ReelCommentReplyId, l.UserId })
          .IsUnique();



        modelBuilder.Entity<BrandReview>()
            .HasIndex(r => new { r.BrandId, r.UserId })
            .IsUnique();

        modelBuilder.Entity<ProductReview>()
            .HasIndex(r => new { r.ProductId, r.UserId })
            .IsUnique();


        modelBuilder.Entity<Notification>()
              .HasOne(n => n.User)
              .WithMany(u => u.Notifications)  
              .HasForeignKey(n => n.UserId)
              .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Brand>()
              .HasOne(b => b.user)
              .WithOne(u => u.Brand)
              .HasForeignKey<Brand>(b => b.UserId)
              .OnDelete(DeleteBehavior.NoAction);
       
        modelBuilder.Entity<Brand>()
            .HasIndex(b => b.UserId)
            .IsUnique();


        modelBuilder.Entity<Brand>()
                  .HasOne(b => b.BrandVerification)
                  .WithOne(v => v.Brand)
                  .HasForeignKey<BrandVerification>(v => v.BrandId)
                  .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<Brand>()
               .HasOne(b => b.RejectionReason)
               .WithMany(r => r.Brands)
               .HasForeignKey(b => b.RejectionReasonId)
               .OnDelete(DeleteBehavior.SetNull);

        #region Chat
        modelBuilder.Entity<ChatRoom>(b =>
        {
            b.ToTable("ChatRooms");
            b.HasOne(cr => cr.User1)
                .WithMany()
                .HasForeignKey(cr => cr.User1Id)
                .OnDelete(DeleteBehavior.Restrict);

            b.HasOne(cr => cr.User2)
                .WithMany()
                .HasForeignKey(cr => cr.User2Id)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Message>(b =>
        {
            b.ToTable("Messages");
            b.HasOne(m => m.Room)
                .WithMany(r => r.Messages)
                .HasForeignKey(m => m.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);
        });
        #endregion
        
        modelBuilder.Entity<DiscountCode>(b =>
        {
            b.HasIndex(d => d.Code).IsUnique();
            b.Property(d => d.DiscountValue).HasPrecision(18, 2);
        });

        modelBuilder.Entity<OrderProduct>(b =>
        {
            b.Property(op => op.AppliedDiscountCodeAmount).HasPrecision(18, 2);
        });

        modelBuilder.Entity<Offer>(b =>
        {
            b.Property(o => o.DiscountPercentage).HasPrecision(18, 2);
        });
    }

    public override async Task<int> SaveChangesAsync(
    CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker
            .Entries<BaseEntity>();

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = DateTime.UtcNow;
                entry.Entity.UpdatedAt = DateTime.UtcNow;
            }
            else if (entry.State == EntityState.Modified)
            {
                entry.Entity.UpdatedAt = DateTime.UtcNow;
            }
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<Reel> Reels { get; set; }
    public DbSet<UserReelShare> UserReelShares { get; set; }
    public DbSet<ProductReview> Reviews { get; set; }
    public DbSet<UserInterest> UserInterests { get; set; }
    public DbSet<Interest> Interests { get; set; }
    public DbSet<BrandReviewLike> BrandReviewLikes { get; set; }
    public DbSet<ProductReviewLike> ProductReviewLikes { get; set; }
    public DbSet<ProductReviewDislike> ProductReviewDislikes { get; set; }
    public DbSet<UserBrandFollow> UserBrandFollows { get; set; }
    public DbSet<WishlistItem> WishlistItems { get; set; }

    public DbSet<Offer> Offers { get; set; }
    public DbSet<OfferProduct> OfferProducts { get; set; }

    public DbSet<ReelCommentReply> ReelCommentReplies { get; set; }
    public DbSet<ReelCommentReplyLove> ReelCommentReplyLoves { get; set; }
    public DbSet<OrderTracking> OrderTrackings { get; set; }

    public DbSet<Notification> Notifications { get; set; }
    public DbSet<ContactMessage> ContactMessages { get; set; } 
    public DbSet<RejectionReason> RejectionReasons { get; set; }
    public DbSet<BrandVerification> BrandVerification { get; set; }
    public DbSet<ChatRoom> ChatRooms { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<DiscountCode> DiscountCodes { get; set; }

    public DbSet<BrandSettlement> BrandSettlements { get; set; }
    public DbSet<ShippingSettlement> ShippingSettlements { get; set; }
    public DbSet<WithdrawalRequest> WithdrawalRequests { get; set; }
    public DbSet<FinancialAuditLog> FinancialAuditLogs { get; set; }
    public DbSet<ShippingCompany> ShippingCompanies { get; set; }
    public DbSet<BrandSocialLink> BrandSocialLinks { get; set; }
}
