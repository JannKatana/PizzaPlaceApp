using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaPlaceApp.Application.Contracts.Services;
using PizzaPlaceApp.Application.Contracts.Services.FileParsing;

namespace PizzaPlaceApp.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IFileParsingService, FileParsingService>();
        
        return services;
    }
}