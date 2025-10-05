using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.AiChatsEntities;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.DisputeEntities;
using ReelsCommerceSystem.Domain.Entities.ForumPostEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.ProductCartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Entities.UserInterestEntities;
using ReelsCommerceSystem.Domain.Entities.UserOrderEntities;

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
        { b.ToTable("Users"); });
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
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<AiChat> AiChats { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Dispute> Disputes { get; set; }
    public DbSet<ForumPost> ForumPosts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<ProductCart> ProductCarts { get; set; }
    public DbSet<Reel> Reels { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<UserInterest> UserInterests { get; set; }
    public DbSet<UserOrder> UserOrders { get; set; }
}


