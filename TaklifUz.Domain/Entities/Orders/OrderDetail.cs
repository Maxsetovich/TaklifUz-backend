using TaklifUz.Domain.Entities.Products;

namespace TaklifUz.Domain.Entities.Orders;

public class OrderDetail : Auditable
{
    public long OrderId { get; set; }
    public Order? Order { get; set; }
    public long ProductId { get; set; }
    public Product? Product { get; set; }

    public int Quantity { get; set; }
    public double ProductsPrice { get; set; }
}
