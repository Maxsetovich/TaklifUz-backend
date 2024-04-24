using TaklifUz.Domain.Entities.Orders;

namespace TaklifUz.Domain.Entities.Threads;

public class ProductThread : Auditable
{
    public long LinkId { get; set; }
    public ProductLink? Link { get; set; }

    public long OrderId { get; set; }
    public Order? Order { get; set; }
}
