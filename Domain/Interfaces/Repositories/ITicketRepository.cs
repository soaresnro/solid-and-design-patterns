using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface ITicketRepository
{
    Task<IEnumerable<Ticket>> GetAll();
    Task<Ticket> GetById(Guid id);
    Task Create(Ticket user);
    Task Update(Ticket user);
    Task Delete(Guid id);
}