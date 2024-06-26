using Dapper.FluentMap.Dommel.Mapping;
using Domain.Entities;

namespace Infra.Data.Mappers;

public class TicketMap : DommelEntityMap<Ticket>
{
    public TicketMap()
    {
        ToTable("ticket");

        Map(x => x.TicketId)
            .ToColumn("ticket_id")
            .IsKey();

        Map(x=> x.EventId).ToColumn("event_id");
        Map(x=> x.Email).ToColumn("email");
        Map(x=> x.Price).ToColumn("price");

    } 
}