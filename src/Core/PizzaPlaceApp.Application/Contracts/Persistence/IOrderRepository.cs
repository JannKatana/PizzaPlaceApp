using PizzaPlaceApp.Domain;

namespace PizzaPlaceApp.Application.Contracts.Persistence;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<Order?> GetOrderWithDetails(int id);
}