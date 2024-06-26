using Domain.Commands.Ticket;
using Domain.Dtos.Ticket;
using Domain.Interfaces.Services.Ticket;

namespace Application.Services;

public class PurchaseTicketService : IPurchaseTicketService
{
    public async Task<PurchaseTicketResult> Execute(PurchaseTicketCommand inputPurchaseTicket)
    {
        return await Task.FromResult(new PurchaseTicketResult
        {
            TicketId = Guid.NewGuid().ToString(),
            Email = inputPurchaseTicket.Email,
            EventId = inputPurchaseTicket.EventId
        });
    }
}