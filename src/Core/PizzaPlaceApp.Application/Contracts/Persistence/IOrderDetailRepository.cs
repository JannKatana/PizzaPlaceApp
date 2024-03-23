using PizzaPlaceApp.Domain;

namespace PizzaPlaceApp.Application.Contracts.Persistence;

public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
{
    Task<OrderDetail?> GetOrderDetailBy(int id);
}