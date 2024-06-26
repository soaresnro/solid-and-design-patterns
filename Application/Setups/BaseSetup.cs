using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Application.Setups;

[ExcludeFromCodeCoverage]
public static class BaseSetup
{
    /// <summary>
    /// Method responsible for configuring the application culture.
    /// </summary>
    public static void ConfigureCulture()
    {
        CultureInfo ci = new("pt-BR");
        CultureInfo.DefaultThreadCurrentCulture = ci;
        CultureInfo.DefaultThreadCurrentUICulture = ci;
        CultureInfo.CurrentCulture = ci;
        CultureInfo.CurrentUICulture = ci;

        Thread.CurrentThread.CurrentCulture = ci;
        Thread.CurrentThread.CurrentUICulture = ci;
    }

    /// <summary>
    /// Method responsible for starting log generation dependencies.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddLogging(this IServiceCollection services)
    {
        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo.Async(wt => wt.Console(outputTemplate: "[{Timestamp:dd/MM/yyyy HH:mm:ss} {Level:u3}] {Properties:j} {Message:lj} {NewLine}{Exception}"))
            .CreateLogger();

        services.AddLogging(builder =>
        {
            builder.ClearProviders();
            builder.AddSerilog();
        });

        return services;
    }
    
    /// <summary>
    /// Method responsible for starting Mapster dependencies to execute mappings in projects.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddMapster(this IServiceCollection services)
    {
        var config = TypeAdapterConfig.GlobalSettings;

        var assemblies = new[]
        {
            Assembly.Load("Api"),
            Assembly.Load("Application"),
            Assembly.Load("Infra.Data"),
        };
        
        config.Scan(assemblies);
        
        services.AddScoped<IMapper>(_ => new Mapper(config));

        return services;
    }
}