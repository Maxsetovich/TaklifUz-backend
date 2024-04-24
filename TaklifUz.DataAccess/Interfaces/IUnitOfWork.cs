using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Admins;
using TaklifUz.DataAccess.Interfaces.Categories;
using TaklifUz.DataAccess.Interfaces.Heads;
using TaklifUz.DataAccess.Interfaces.Orders;
using TaklifUz.DataAccess.Interfaces.Products;
using TaklifUz.DataAccess.Interfaces.Threads;
using TaklifUz.DataAccess.Interfaces.Users;

namespace TaklifUz.DataAccess.Interfaces;

public interface IUnitOfWork
{
    // Admins
    public IAdminRepository Admins { get; }
    
    // Heads
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

    public Task<int> SaveChangeAsync();
}
