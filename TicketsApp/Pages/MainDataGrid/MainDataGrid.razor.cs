using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketsApp.Services;

namespace TicketsApp.Pages.MainDataGrid
{
    public partial class MainDataGrid
    {
        [Inject]
        private UserDataService UserDataService { get; set; }
        [Inject]
        private RoleDataService RoleDataService { get; set; }
        [Inject]
        private TicketDataService TicketDataService { get; set; }
        [Inject]
        private NoteDataService NoteDataService { get; set; }
        [Inject]
        private CustomerDataService CustomerDataService { get; set; }
        [Inject]
        private TicketTypeDataService TicketTypeDataService { get; set; }

        public ApplicationDbContext db { get; set; }

        public List<User> Userslist { get; set; }
        public List<DataAccess.Models.Role> Roleslist { get; set; }
        public List<Note> Noteslist { get; set; }
        public IEnumerable<DataAccess.Models.Ticket> Ticketslist { get; set; }
        public IEnumerable<DataAccess.Models.Ticket> FilteredTicketslist { get; set; }
        public List<DataAccess.Models.TicketType> TicketTypeslist { get; set; }
        public List<DataAccess.Models.Customer> Customerslist { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public int OuverStateCount { get; set; } = 0;
        public int FermeStateCount { get; set; } = 0;
        public int EnDevStateCount { get; set; } = 0;
        public int EnAttenteStateCount { get; set; } = 0;
        public int ResoluStateCount { get; set; } = 0;

        public IEnumerable<DataAccess.Models.Ticket> ResoluState { get; set; }
        public IEnumerable<DataAccess.Models.Ticket> EnAttenteState { get; set; }
        public IEnumerable<DataAccess.Models.Ticket> EnDevState { get; set; }
        public IEnumerable<DataAccess.Models.Ticket> FermeState { get; set; }
        public IEnumerable<DataAccess.Models.Ticket> OuverState { get; set; }

        protected override void OnInitialized()
        {

            //db = new ApplicationDbContext();
            Userslist = UserDataService.GetAllUsers();
            Roleslist = RoleDataService.GetAllRoles();
            Noteslist = NoteDataService.GetAllNotes();
            Customerslist = CustomerDataService.GetAllCustomers();
            TicketTypeslist = TicketTypeDataService.GetAllTicketTypes();
            Ticketslist = TicketDataService.GetAllTickets();
            FilteredTicketslist = TicketDataService.GetTicketByDate( StartDate , EndDate);
            OuverStateCount = FilteredTicketslist.Where(t => t.TicketState == TicketState.Ouvert).Count();
            FermeStateCount = FilteredTicketslist.Where(t => t.TicketState == TicketState.Ferme).Count();
            EnDevStateCount = FilteredTicketslist.Where(t => t.TicketState == TicketState.Endeveloppement).Count();
            EnAttenteStateCount = FilteredTicketslist.Where(t => t.TicketState == TicketState.Enattente).Count();
            ResoluStateCount = FilteredTicketslist.Where(t => t.TicketState == TicketState.Resolu).Count();

            OuverState = FilteredTicketslist.Where(t => t.TicketState == TicketState.Ouvert);
            FermeState = FilteredTicketslist.Where(t => t.TicketState == TicketState.Ferme);
            EnDevState = FilteredTicketslist.Where(t => t.TicketState == TicketState.Endeveloppement);
            EnAttenteState = FilteredTicketslist.Where(t => t.TicketState == TicketState.Enattente);
            ResoluState = FilteredTicketslist.Where(t => t.TicketState == TicketState.Resolu);
        }

        public void RefreshGrid()
        {
            OnInitialized();
        }

    }
}
