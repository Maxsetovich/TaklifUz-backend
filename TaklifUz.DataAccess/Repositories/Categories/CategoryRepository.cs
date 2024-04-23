using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces;
using TaklifUz.DataAccess.Interfaces.Categories;
using TaklifUz.Domain.Entities.Categories;

namespace TaklifUz.DataAccess.Repositories.Categories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
