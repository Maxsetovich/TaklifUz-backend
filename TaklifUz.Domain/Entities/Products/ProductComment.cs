using TaklifUz.Domain.Entities.Users;

namespace TaklifUz.Domain.Entities.Products;

public class ProductComment : Auditable
{
    public long UserId { get; set; } 
    public User? User { get; set; }
    public long ProductId { get; set; }
    public Product? Product { get; set; }

    public string Comment { get; set; } = String.Empty;
}
