using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TicketsApp.Services
{
    public class TicketDataService : ITicketDataService
    {
        private readonly ApplicationDbContext _appContext;

        public TicketDataService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        public async Task<List<Ticket>> GetAllTickets()
        {
            return await _appContext.Tickets.ToListAsync();
        }

        public async Task<Ticket> GetTicketDetails(long ticketId)
        {
            Ticket ticket = await _appContext.Tickets.FirstOrDefaultAsync(c => c.TicketId.Equals(ticketId));
            return ticket;
        }

        public async Task<Ticket> AddTicket(Ticket ticket)
        {
            await _appContext.Tickets.AddAsync(ticket);
            await _appContext.SaveChangesAsync();
            return ticket;
        }

        public async Task UpdateTicket(Ticket ticket)
        {
            _appContext.Tickets.Update(ticket);
            await _appContext.SaveChangesAsync();
        }

        public async Task DeleteTicket(Ticket ticket)
        {
            _appContext.Remove(ticket);
            await _appContext.SaveChangesAsync();
        }
    }
}
