using PizzaPlaceApp.Domain;

namespace PizzaPlaceApp.Application.Features.Order.Queries.GetOrders;

public class OrderDto
{
    public int OrderId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
}