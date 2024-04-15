using TaklifUz.Domain.Entities.Categories;
using TaklifUz.Domain.Entities.Orders;

namespace TaklifUz.Domain.Entities.Products;

public class Product : Auditable
{
    public long CategoryId { get; set; }
    public Category? Category { get; set; }
    
    public string Name { get; set; } = String.Empty;
    public double UnitPrice { get; set; }
    public string Description { get; set; } = String.Empty;
    
    public IList<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
    public IList<ProductComment> ProductComments { get; set; } = new List<ProductComment>();
    public IList<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
