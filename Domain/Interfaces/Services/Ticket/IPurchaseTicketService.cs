using Domain.Commands.Ticket;
using Domain.Dtos.Ticket;

namespace Domain.Interfaces.Services.Ticket;

public interface IPurchaseTicketService
{
    Task<PurchaseTicketResult> Execute(PurchaseTicketCommand inputPurchaseTicket);
}