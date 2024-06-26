using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Settings;
using Microsoft.Extensions.Options;
using Npgsql;

namespace Infra.Data.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly NpgsqlConnection _connection;
    
    public TicketRepository(IOptions<DbSettings> dbSeetings)
    {
        _connection = new NpgsqlConnection(dbSeetings.Value.ConnectionString);
    }
    
    public async Task<IEnumerable<Ticket>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Ticket> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task Create(Ticket user)
    {
        throw new NotImplementedException();
    }

    public async Task Update(Ticket user)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}