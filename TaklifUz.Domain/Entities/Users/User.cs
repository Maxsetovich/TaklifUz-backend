using TaklifUz.Domain.Entities.Orders;
using TaklifUz.Domain.Entities.Products;

namespace TaklifUz.Domain.Entities.Users;

public class User : Auditable
{
    public string Name { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
    public string Region { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;

    public IList<ProductComment> ProductComments { get; set; } = new List<ProductComment>();
    public IList<Order> Orders { get; set; } = new List<Order>();

    //Add product List
}
