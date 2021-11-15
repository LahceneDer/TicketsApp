using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;

namespace TicketsApp.Services
{
    public interface ITicketDataService
    {
        Task<List<Ticket>> GetAllTickets();
        Task<Ticket> GetTicketDetails(long ticketId);
        Task<Ticket> AddTicket(Ticket ticket);
        Task UpdateTicket(Ticket ticket);
        Task DeleteTicket(Ticket ticket);

    }
}
