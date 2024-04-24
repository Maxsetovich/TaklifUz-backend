using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces;
using TaklifUz.DataAccess.Interfaces.Admins;
using TaklifUz.DataAccess.Interfaces.Categories;
using TaklifUz.DataAccess.Interfaces.Heads;
using TaklifUz.DataAccess.Interfaces.Orders;
using TaklifUz.DataAccess.Interfaces.Products;
using TaklifUz.DataAccess.Interfaces.Threads;
using TaklifUz.DataAccess.Interfaces.Users;
using TaklifUz.DataAccess.Repositories.Admins;
using TaklifUz.DataAccess.Repositories.Categories;
using TaklifUz.DataAccess.Repositories.Heads;
using TaklifUz.DataAccess.Repositories.Orders;
using TaklifUz.DataAccess.Repositories.Products;
using TaklifUz.DataAccess.Repositories.Threads;
using TaklifUz.DataAccess.Repositories.Users;

namespace TaklifUz.DataAccess.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly AppDbContext appDbContext;

    // Admins
    public IAdminRepository Admins { get; }

    // Admins
    public IHeadRepository Heads { get; }

    // Users
    public IUserRepository Users { get; }

    // Categories
    public ICategoryRepository Categories { get; }

    // Orders
    public IOrderRepository Orders { get; }
    public IOrderDetailRepository OrderDetails { get; }

    // Products
    public IProductRepository Products { get; }
    public IProductCommentRepository ProductComments { get; }
    public IProductImageRepository ProductImages { get; }

    // Threads
    public IProductThreadRepository ProductThreads { get; }
    public IProductLinkRepository ProductLinks { get; }

    public UnitOfWork(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;

        // Admins
        this.Admins = new AdminRepository(appDbContext);

        // Heads
        this.Heads = new HeadRepository(appDbContext);

        // Users
        this.Users = new UserRepository(appDbContext);

        // Categories
        this.Categories = new CategoryRepository(appDbContext);

        // Orders
        this.Orders = new OrderRepository(appDbContext);
        this.OrderDetails = new OrderDetailRepository(appDbContext);

        // Products
        this.Products = new ProductRepository(appDbContext);
        this.ProductImages = new ProductImageRepository(appDbContext);
        this.ProductComments = new ProductCommentRepository(appDbContext);

        // Threads
        this.ProductThreads = new ProductThreadRepository(appDbContext);
        this.ProductLinks = new ProductLinkRepository(appDbContext);
    }

    public async Task<int> SaveChangeAsync()
        => await appDbContext.SaveChangesAsync();

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
