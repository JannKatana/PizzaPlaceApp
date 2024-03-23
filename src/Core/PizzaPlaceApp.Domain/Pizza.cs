using PizzaPlaceApp.Domain.Common;

namespace PizzaPlaceApp.Domain;

public class Pizza: BaseEntity
{
    public string PizzaId { get; set; } = string.Empty;
    public string PizzaType { get; set; } = string.Empty;
    public string Size { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
