using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces.Products;
using TaklifUz.Domain.Entities.Products;

namespace TaklifUz.DataAccess.Repositories.Products;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
