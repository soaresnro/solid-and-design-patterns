namespace Domain.Dtos.Ticket;

public record PurchaseTicketResult
{
    public string TicketId { get; set; }

    public string EventId { get; set; }

    public string Email { get; set; }
}