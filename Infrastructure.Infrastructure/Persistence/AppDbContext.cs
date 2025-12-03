using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.InterestEntities;
using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Entities.UserInterestEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence;

public class AppDbContext :IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){ }
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
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<Reel> Reels { get; set; }
    public DbSet<ProductReview> Reviews { get; set; }
    public DbSet<UserInterest> UserInterests { get; set; }
    public DbSet<Interest> Interests { get; set; }
    public DbSet<BrandReviewLike> BrandReviewLikes { get; set; }
    public DbSet<UserBrandFollow> UserBrandFollows { get; set; }
    public DbSet<WishlistItem> WishlistItems { get; set; }

}


