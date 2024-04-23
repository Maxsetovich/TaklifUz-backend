using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Orders;
using TaklifUz.Domain.Entities.Orders;

namespace TaklifUz.DataAccess.Repositories.Orders;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
