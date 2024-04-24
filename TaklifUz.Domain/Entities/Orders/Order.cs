using TaklifUz.Domain.Entities.Threads;
using TaklifUz.Domain.Entities.Users;

namespace TaklifUz.Domain.Entities.Orders;

public class Order : Auditable
{
    public long UserId { get; set; }
    public User? User { get; set; }

    public string Status { get; set; } = String.Empty;
    public double TotalPrice { get; set; }

    public IList<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    public IList<ProductThread> ProductThreads { get; set; } = new List<ProductThread>();
}
