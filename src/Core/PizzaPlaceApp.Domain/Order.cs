using PizzaPlaceApp.Domain.Common;

namespace PizzaPlaceApp.Domain;

public class Order : BaseEntity
{
    public int OrderId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public List<OrderDetail> OrderDetails { get; set; } = new();
}