namespace PizzaPlaceApp.Application.Features.OrderDetail.Queries.GetOrderDetails;

public class OrderDetailDto
{
    public int OrderId { get; set; }
    public string PizzaId { get; set; }
    public int Quantity { get; set; }
}