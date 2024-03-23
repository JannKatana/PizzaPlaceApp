using PizzaPlaceApp.Domain.Common;

namespace PizzaPlaceApp.Domain;

public class PizzaType : BaseEntity
{
    public string PizzaTypeId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Ingredients { get; set; } = string.Empty;
}