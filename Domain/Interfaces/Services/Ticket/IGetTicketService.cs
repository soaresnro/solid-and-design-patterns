using Domain.Dtos.Ticket;

namespace Domain.Interfaces.Services.Ticket;

public interface IGetTicketService
{
    Task<GetTicketResult> Execute(string ticketId);
}