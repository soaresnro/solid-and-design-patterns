namespace Domain.Commands.Ticket;

public record PurchaseTicketCommand
{
    public string EventId { get; init; } = string.Empty;

    public string Email { get; init; } = string.Empty;
}