using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DevExpress.Data.Filtering;
using Microsoft.EntityFrameworkCore;

namespace TicketsApp.Services
{
    public class TicketDataService
    {
        private readonly ApplicationDbContext _appContext;


        public TicketDataService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }


        public Ticket AddTicket(Ticket ticket)
        {
            _appContext.Tickets.Add(ticket);
            _appContext.SaveChanges();
            return ticket;
        }


        public void DeleteTicket(int ticketId)
        {
            var c = _appContext.Tickets.Find(ticketId);
            _appContext.Tickets.Remove(c);
            _appContext.SaveChanges();
        }


        public List<Ticket> GetAllTickets()
        {
            var tickets= _appContext.Tickets.ToList();
            return tickets;
        }

        public Ticket GetTicketDetails(long ticketId)
        {
            return _appContext.Tickets.Find(ticketId);
        }


        public Ticket UpdateTicket(Ticket ticket, Dictionary<string, object> newValue)
        {
            foreach (var field in newValue.Keys)
            {
                switch (field)
                {
                    case "UserId":
                        ticket.UserId = (int)newValue[field];
                        break;
                    case "TicketTypeId":
                        ticket.TicketTypeId = (int)newValue[field];
                        break;
                    case "TicketId":
                        ticket.TicketId = (int)newValue[field];
                        break;
                    case "CustomerId":
                        ticket.CustomerId = (int)newValue[field];
                        break;
                    case "Description":
                        ticket.Description = (string)newValue[field];
                        break;
                    case "Date":
                        ticket.Date = (DateTime)newValue[field];
                        break;
                    case "Duree":
                        ticket.Duree = (DateTime)newValue[field];
                        break;
                    case "ticketStates":
                        ticket.TicketState = (TicketState)newValue[field];
                        break;
                    case "ticketPriorites":
                        ticket.TicketPriorite = (TicketPriorite)newValue[field];
                        break;
                    case "DateDeResoudre":
                        ticket.DateDeResoudre = (DateTime)newValue[field];
                        break;
                }
            }
            _appContext.SaveChanges();
            return ticket;
        }

        public IEnumerable<Ticket> GetTicketByDate(DateTime StartDate, DateTime EndDate)
        {
            var Alltickets = _appContext.Tickets.ToList();
            return Alltickets.Where(t => t.Date >= StartDate & t.Date <= EndDate);

        }
    }
}
