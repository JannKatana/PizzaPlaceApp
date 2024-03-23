namespace PizzaPlaceApp.Application.Features.Import.Commands.ImportOrders;

public class ImportOrdersDto
{
    public int order_id { get; set; }
    public DateOnly date { get; set; }
    public TimeOnly time { get; set; }
}