using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Heads;
using TaklifUz.Domain.Entities.Heads;

namespace TaklifUz.DataAccess.Repositories.Heads;

public class HeadRepository : GenericRepository<Head>, IHeadRepository
{
    public HeadRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
