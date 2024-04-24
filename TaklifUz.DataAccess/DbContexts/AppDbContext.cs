using Microsoft.EntityFrameworkCore;
using TaklifUz.Domain.Entities.Admins;
using TaklifUz.Domain.Entities.Categories;
using TaklifUz.Domain.Entities.Heads;
using TaklifUz.Domain.Entities.Orders;
using TaklifUz.Domain.Entities.Products;
using TaklifUz.Domain.Entities.Threads;
using TaklifUz.Domain.Entities.Users;

namespace TaklifUz.DataAccess.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Head> Heads { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductComment> ProductComments { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<ProductThread> ProductThreads { get; set; }
    public DbSet<ProductLink> ProductLinks { get; set; }
}
