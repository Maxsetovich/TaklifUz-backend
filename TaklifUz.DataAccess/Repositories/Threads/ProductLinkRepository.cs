using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Threads;
using TaklifUz.Domain.Entities.Threads;

namespace TaklifUz.DataAccess.Repositories.Threads;

public class ProductLinkRepository : GenericRepository<ProductLink>, IProductLinkRepository
{
    public ProductLinkRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
