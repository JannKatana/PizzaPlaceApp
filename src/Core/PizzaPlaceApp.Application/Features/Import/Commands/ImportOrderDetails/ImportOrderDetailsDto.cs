namespace PizzaPlaceApp.Application.Features.Import.Commands.ImportOrderDetails;

public class ImportOrderDetailsDto
{
    public int order_details_id { get; set; }
    public int order_id { get; set; }
    public string pizza_id { get; set; } = string.Empty;
    public int quantity { get; set; }
}