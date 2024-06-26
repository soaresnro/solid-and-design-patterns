using Application.Services;
using Domain.Commands.Ticket;

namespace SolidAndDesignPatterns.Test;

public class PurchaseTickerTests
{
    [Fact]
    public async Task DeveComprarUmIngresso_Success()
    {
        //Arrange
        var purchaseTicketCommand = new PurchaseTicketCommand
        {
            EventId = "8445B58B-5826-4D72-B4A4-7A11DBFBAB66",
            Email = "john.doe@gmail.com"
        };
        
        //Act
        var purchaseTicketService = new PurchaseTicketService();
        var purchaseTicketResult = await purchaseTicketService.Execute(purchaseTicketCommand);

        var getTicketService = new GetTicketService();
        var getTicketResult = await getTicketService.Execute(purchaseTicketResult.TicketId);
        
        //Asset
        Assert.NotNull(purchaseTicketResult.TicketId);
        Assert.Equal(getTicketResult.TicketId, purchaseTicketResult.TicketId);
        Assert.Equal(getTicketResult.EventId, purchaseTicketResult.EventId);
        Assert.Equal(getTicketResult.Email, purchaseTicketResult.Email);
        Assert.Equal(100, getTicketResult.Price);
    }
}
