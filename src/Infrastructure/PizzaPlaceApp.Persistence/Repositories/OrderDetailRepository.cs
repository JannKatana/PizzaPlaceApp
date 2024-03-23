using PizzaPlaceApp.Application.Contracts.Persistence;
using PizzaPlaceApp.Domain;
using PizzaPlaceApp.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace PizzaPlaceApp.Persistence.Repositories;

public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(PizzaPlaceDatabaseContext context) : base(context)
    {
    }

    public async Task<OrderDetail?> GetOrderDetailBy(int id)
    {
        return await Context.OrderDetails
            .FirstOrDefaultAsync(q => q.Id == id);
    }

    public async Task<List<OrderDetail>> GetOrderDetails()
    {
        return await Context.OrderDetails
            .ToListAsync();
    }

   
}