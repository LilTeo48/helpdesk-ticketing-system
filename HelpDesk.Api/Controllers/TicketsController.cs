using HelpDesk.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketsController : ControllerBase
{
    private static readonly List<Ticket> Tickets = new();

    [HttpGet]
    public IActionResult GetTickets()
    {
        return Ok(Tickets);
    }

    [HttpPost]
    public IActionResult CreateTicket(Ticket ticket)
    {
        ticket.Id = Tickets.Count + 1;
        ticket.CreatedAt = DateTime.UtcNow;

        Tickets.Add(ticket);

        return CreatedAtAction(
            nameof(GetTickets),
            ticket
        );
    }

}