using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;

namespace TicketsApp.Services
{
    public interface INoteDataService
    {
        Task<IEnumerable<Note>> GetAllNotes();
        Task<User> GetTicketDetails(long noteId);
        Task<User> AddTicket(Note note);
        Task UpdateTicket(Note note);
        Task DeleteTicket(long noteId);

    }
}
