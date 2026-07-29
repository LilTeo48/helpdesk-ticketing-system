using HelpDesk.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketsController : ControllerBase
{
    private static readonly List<Ticket> Tickets = new();
    private static int _nextId = 1;

    [HttpGet]
    public ActionResult<IEnumerable<Ticket>> GetTickets()
    {
        return Ok(Tickets);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Ticket> GetTicketById(int id)
    {
        Ticket? ticket = Tickets.FirstOrDefault(ticket => ticket.Id == id);

        if (ticket is null)
        {
            return NotFound(new
            {
                message = $"Ticket with ID {id} was not found."
            });
        }

        return Ok(ticket);
    }

    [HttpPost]
    public ActionResult<Ticket> CreateTicket(Ticket ticket)
    {
        ticket.Id = _nextId++;
        ticket.CreatedAt = DateTime.UtcNow;

        Tickets.Add(ticket);

        return CreatedAtAction(
            nameof(GetTicketById),
            new { id = ticket.Id },
            ticket
        );
    }

    [HttpPut("{id:int}")]
    public ActionResult<Ticket> UpdateTicket(int id, Ticket updatedTicket)
    {
        Ticket? existingTicket =
            Tickets.FirstOrDefault(ticket => ticket.Id == id);

        if (existingTicket is null)
        {
            return NotFound(new
            {
                message = $"Ticket with ID {id} was not found."
            });
        }

        existingTicket.Title = updatedTicket.Title;
        existingTicket.Description = updatedTicket.Description;
        existingTicket.Priority = updatedTicket.Priority;
        existingTicket.Status = updatedTicket.Status;

        return Ok(existingTicket);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteTicket(int id)
    {
        Ticket? ticket = Tickets.FirstOrDefault(ticket => ticket.Id == id);

        if (ticket is null)
        {
            return NotFound(new
            {
                message = $"Ticket with ID {id} was not found."
            });
        }

        Tickets.Remove(ticket);

        return NoContent();
    }
}