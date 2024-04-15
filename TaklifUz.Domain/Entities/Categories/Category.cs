using TaklifUz.Domain.Entities.Products;

namespace TaklifUz.Domain.Entities.Categories;

public class Category : Auditable
{
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;

    public IList<Product> Products { get; set; } = new List<Product>();
}
