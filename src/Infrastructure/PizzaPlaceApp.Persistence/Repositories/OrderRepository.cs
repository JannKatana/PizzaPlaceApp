using PizzaPlaceApp.Application.Contracts.Persistence;
using PizzaPlaceApp.Domain;
using PizzaPlaceApp.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace PizzaPlaceApp.Persistence.Repositories;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(PizzaPlaceDatabaseContext context) : base(context)
    {
    }

    public async Task<Order?> GetOrderWithDetails(int id)
    {
        return await Context.Orders
            .Include(q => q.OrderDetails)
            .FirstOrDefaultAsync(q => q.Id == id);
    }

    public async Task<List<Order>> GetOrdersWithDetails()
    {
        return await Context.Orders
            .ToListAsync();
    }
}