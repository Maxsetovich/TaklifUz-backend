using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Admins;
using TaklifUz.Domain.Entities.Admins;

namespace TaklifUz.DataAccess.Repositories.Admins;

public class AdminRepository : GenericRepository<Admin>, IAdminRepository
{
    public AdminRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
