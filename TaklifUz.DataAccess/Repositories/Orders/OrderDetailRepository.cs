using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Orders;
using TaklifUz.Domain.Entities.Orders;

namespace TaklifUz.DataAccess.Repositories.Orders;

public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
