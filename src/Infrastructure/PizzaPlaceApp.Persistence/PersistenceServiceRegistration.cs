using PizzaPlaceApp.Application.Contracts.Persistence;
using PizzaPlaceApp.Persistence.DatabaseContext;
using PizzaPlaceApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PizzaPlaceApp.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PizzaPlaceDatabaseContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("PizzaPlaceAppConnectionString"));
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IOrderRepository, OrderRepository>();

        return services;
    }
}