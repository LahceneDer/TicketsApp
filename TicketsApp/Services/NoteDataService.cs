using DataAccess.Data;
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
    public class NoteDataService 
    {
        private readonly ApplicationDbContext _appContext;

        public NoteDataService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        public Task<User> AddTicket(Note note)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTicket(long noteId)
        {
            throw new NotImplementedException();
        }

        public List<Note> GetAllNotes()
        {
            var notes = _appContext.Notes.ToList();
            return notes;
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
