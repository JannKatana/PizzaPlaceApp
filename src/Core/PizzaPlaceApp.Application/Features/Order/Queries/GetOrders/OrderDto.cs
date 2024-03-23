using PizzaPlaceApp.Domain;

namespace PizzaPlaceApp.Application.Features.Order.Queries.GetOrders;

public class OrderDto
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public List<OrderDetail> OrderDetails { get; set; } = new();
}