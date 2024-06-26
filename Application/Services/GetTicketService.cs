using Domain.Dtos.Ticket;
using Domain.Interfaces.Services.Ticket;

namespace Application.Services;

public class GetTicketService : IGetTicketService
{
    public async Task<GetTicketResult> Execute(string ticketId)
    {
        return await Task.FromResult(new GetTicketResult()
        {
            TicketId = ticketId,
            Email = "john.doe@gmail.com",
            EventId = "8445B58B-5826-4D72-B4A4-7A11DBFBAB66",
            Price = 100
        });
    }
}