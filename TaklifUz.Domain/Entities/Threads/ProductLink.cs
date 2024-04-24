using TaklifUz.Domain.Entities.Admins;
using TaklifUz.Domain.Entities.Products;

namespace TaklifUz.Domain.Entities.Threads;

public class ProductLink : Auditable
{
    public long adminId { get; set; }
    public Admin? Admin { get; set; }

    public long ProductId { get; set; }
    public Product? Product { get; set; }

    public string Name { get; set; } = String.Empty;
    public string UrlLink { get; set; } = String.Empty;

    public IList<ProductThread> Threads { get; set; } = new List<ProductThread>();
}
