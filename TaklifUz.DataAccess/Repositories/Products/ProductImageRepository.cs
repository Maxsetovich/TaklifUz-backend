using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Products;
using TaklifUz.Domain.Entities.Products;

namespace TaklifUz.DataAccess.Repositories.Products;

public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository
{
    public ProductImageRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
