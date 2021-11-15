using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TicketsApp.Services
{
    public class NoteDataService : INoteDataService
    {
        public Task<User> AddTicket(Note note)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTicket(long noteId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Note>> GetAllNotes()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetTicketDetails(long noteId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicket(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
