using TaklifUz.Domain.Entities.Orders;

namespace TaklifUz.Domain.Entities.Threads;

public class ProductThread : Auditable
{
    public long ProductLinkId { get; set; }
    public ProductLink? ProductLink { get; set; }

    public long OrderId { get; set; }
    public Order? Order { get; set; }
}
