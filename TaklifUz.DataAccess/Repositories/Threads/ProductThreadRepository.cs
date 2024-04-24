using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Threads;
using TaklifUz.Domain.Entities.Threads;

namespace TaklifUz.DataAccess.Repositories.Threads;

public class ProductThreadRepository : GenericRepository<ProductThread>, IProductThreadRepository
{
    public ProductThreadRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
