using PizzaPlaceApp.Domain.Common;

namespace PizzaPlaceApp.Domain;

public class OrderDetail : BaseEntity
{
    public int OrderDetailId { get; set; }
    
    public int OrderId { get; set; }

    public string PizzaId { get; set; } = string.Empty;

    public int Quantity { get; set; }
}
