namespace PizzaPlaceApp.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateCreated { get; set; }
}
