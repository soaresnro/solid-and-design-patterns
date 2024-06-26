namespace Domain.Dtos.Ticket;

public record GetTicketResult
{
    public string TicketId { get; set; }

    public string EventId { get; set; }

    public string Email { get; set; }

    public decimal Price { get; set; }
}