namespace TaklifUz.Domain.Entities.Products;

public class ProductImage : Auditable
{
    public long ProductId { get; set; }
    public Product? Product { get; set; }
    public string ImagePath { get; set; } = String.Empty;
}
