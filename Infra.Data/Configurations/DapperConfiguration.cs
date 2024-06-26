using Dapper;
using Dapper.FluentMap;
using Infra.Data.Mappers;

namespace Infra.Data.Configurations;

/// <summary>
/// Class responsible for configuring Dapper with Postgres.
/// </summary>
public static class DapperConfiguration
{
    private static readonly object _lockObj = new object();
    
    /// <summary>
    /// Method responsible for configuring Dapper with Postgres.
    /// </summary>
    public static void Configure()
    {
        lock (_lockObj)
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;

            if (FluentMapper.EntityMaps.IsEmpty is false)
                return;

            FluentMapper.Initialize(config =>
            {
                config.AddMap(new TicketMap());
            });
        }
    }
}