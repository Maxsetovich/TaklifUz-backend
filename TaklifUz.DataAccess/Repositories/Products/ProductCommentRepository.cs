using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Products;
using TaklifUz.Domain.Entities.Products;

namespace TaklifUz.DataAccess.Repositories.Products;

public class ProductCommentRepository : GenericRepository<ProductComment>, IProductCommentRepository
{
    public ProductCommentRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
