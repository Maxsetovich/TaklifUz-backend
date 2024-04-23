using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Users;
using TaklifUz.Domain.Entities.Users;

namespace TaklifUz.DataAccess.Repositories.Users;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
