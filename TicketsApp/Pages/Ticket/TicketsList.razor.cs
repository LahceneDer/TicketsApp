using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using BM.Common.Help;
using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using TicketsApp.Services;
using Action = DataAccess.Models.Action;
namespace TicketsApp.Pages.Ticket
{
    public partial class TicketsList
    {
        [Inject] private UserDataService UserDataService { get; set; }
        [Inject] private RoleDataService RoleDataService { get; set; }
        [Inject] private TicketDataService TicketDataService { get; set; }
        [Inject] private NoteDataService NoteDataService { get; set; }
        [Inject] private CustomerDataService CustomerDataService { get; set; }
        [Inject] private TicketTypeDataService TicketTypeDataService { get; set; }

        public ApplicationDbContext db { get; set; }

        public List<User> Userslist { get; set; }
        public List<DataAccess.Models.Role> Roleslist { get; set; }
        public List<Note> Noteslist { get; set; }
        public List<DataAccess.Models.Ticket> Ticketslist { get; set; }
        public List<DataAccess.Models.TicketType> TicketTypeslist { get; set; }
        public List<DataAccess.Models.Customer> Customerslist { get; set; }
        public int userId { get; set; } = 0;
        private bool PopupVisible { get; set; }
        public int TStateInt { get; set; }
        public int TPrioriteInt { get; set; }

        public List<KeyValuePair<string?, int?>> ticketStates { get; set; }
        public List<KeyValuePair<string?, int?>> ticketPriorites { get; set; }
        protected override void OnInitialized()
        {
            ticketStates = GetEnumList<TicketState>();
            ticketPriorites = GetEnumList2<TicketPriorite>();
            Userslist = UserDataService.GetAllUsers();
            Roleslist = RoleDataService.GetAllRoles();
            Noteslist = NoteDataService.GetAllNotes();
            Customerslist = CustomerDataService.GetAllCustomers();
            TicketTypeslist = TicketTypeDataService.GetAllTicketTypes();
            Ticketslist = TicketDataService.GetAllTickets();

        }

        public List<KeyValuePair<string?, int?>> GetEnumList2<T>()
        {
            var list = new List<KeyValuePair<string?, int?>>();
            list.Insert(0, new KeyValuePair<string?, int?>());
            string display = null;
            foreach (TicketPriorite e in Enum.GetValues(typeof(T)))
            {




                display = e.GetType()
                    .GetMember(e.ToString())
                    .FirstOrDefault()?
                    .GetCustomAttribute<DisplayAttribute>()?.Name ?? e.ToString();



                list.Add(new KeyValuePair<string?, int?>(display, (int)e));
            }
            return list;
        }



        public List<KeyValuePair<string?, int?>> GetEnumList<T>()
        {
            var list = new List<KeyValuePair<string?, int?>>();
            list.Insert(0, new KeyValuePair<string?, int?>());
            string display = null;
            foreach (TicketState e in Enum.GetValues(typeof(T)))
            {



                display = e.GetType()
                    .GetMember(e.ToString())
                    .FirstOrDefault()?
                    .GetCustomAttribute<DisplayAttribute>()?.Name ?? e.ToString();



                list.Add(new KeyValuePair<string?, int?>(display, (int)e));
            }
            return list;
        }
        public void RefreshGrid()
        {
            OnInitialized();
        }
        void OnRowUpdating(DataAccess.Models.Ticket x, Dictionary<string, object> newValue)
        {
            TicketDataService.UpdateTicket(x, newValue);
            InvokeAsync(StateHasChanged);
        }
        void OnRowRemoving(DataAccess.Models.Ticket x)
        {
            TicketDataService.DeleteTicket(x.TicketId);
            OnInitialized();
            InvokeAsync(StateHasChanged);
        }
        void OnRowInserting(Dictionary<string, object> newValue)
        {
            var x = new DataAccess.Models.Ticket();
            TicketDataService.AddTicket(TicketDataService.UpdateTicket(x, newValue));
            OnInitialized();
            InvokeAsync(StateHasChanged);
        }
        public void ClosePopup()
        {
            OnInitialized();
            PopupVisible = false;
        }

    }
}
