using PizzaPlaceApp.Domain.Common;

namespace PizzaPlaceApp.Domain;

public class OrderDetail : BaseEntity
{
    public int OrderId { get; set; }
    public Order? Order { get; set; }

    public int PizzaId { get; set; }
    public Pizza? Pizza { get; set; }

    public int Quantity { get; set; }
}
