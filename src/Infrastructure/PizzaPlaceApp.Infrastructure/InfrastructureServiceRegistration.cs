using System.Reflection;
// using PizzaPlaceApp.Application.Contracts.Email;
// using PizzaPlaceApp.Application.Contracts.Logging;
// using PizzaPlaceApp.Application.Models.Email;
// using PizzaPlaceApp.Infrastructure.EmailService;
// using PizzaPlaceApp.Infrastructure.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PizzaPlaceApp.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
        // services.AddTransient<IEmailSender, EmailSender>();
        // services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
        
        return services;
    }
}