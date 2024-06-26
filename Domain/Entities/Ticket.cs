namespace Domain.Entities;

public class Ticket
{
    public string TicketId { get; set; }

    public string EventId { get; set; }

    public string Email { get; set; }

    public decimal Price { get; set; }
}