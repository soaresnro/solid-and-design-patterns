using Application.Services;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Ticket;
using Domain.Settings;
using Infra.Data.Configurations;
using Infra.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Setups;

public static class SetupDependecies
{
    public static void AddDependecies(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddServices()
            .AddRepositories(configuration)
            .AddMapster()
            .AddLogging();
    }

    /// <summary>
    /// Method responsible for starting service dependencies.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        
        services.AddScoped<IPurchaseTicketService, PurchaseTicketService>();
        services.AddScoped<IGetTicketService, GetTicketService>();
        
        return services;
    }
    
    /// <summary>
    /// Method responsible for starting repository dependencies for integration with external data sources.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    private static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<DbSettings>(configuration.GetSection("DbSettings"));
        
        DapperConfiguration.Configure();
        
        //Repositories
        services.AddScoped<ITicketRepository, TicketRepository>();

        return services;
    }
}