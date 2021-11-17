using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BM.Common.Help;
using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using TicketsApp.Services;
using Action = DataAccess.Models.Action;
namespace TicketsApp.Pages.TicketType
{
    public partial class TicketTypesList
    {
        [Inject] 
        private UserDataService UserDataService { get; set; }
        [Inject]
        private RoleDataService RoleDataService { get; set; }
        [Inject]
        private TicketDataService TicketDataService { get; set; }
        [Inject]
        private TicketTypeDataService TicketTypeDataService { get; set; }
        [Inject]
        private NoteDataService NoteDataService { get; set; }
        [Inject]
        private CustomerDataService CustomerDataService { get; set; }

        public ApplicationDbContext db { get; set; }

        public List<User> Userslist { get; set; }
        public List<DataAccess.Models.Role> Roleslist { get; set; }
        public List<Note> Noteslist { get; set; }
        public List<DataAccess.Models.Ticket> Ticketslist { get; set; }
        public List<DataAccess.Models.Customer> Customerslist { get; set; }
        public List<DataAccess.Models.TicketType> TicketTypeslist { get; set; }
        public int userId { get; set; } = 0;
        private bool PopupVisible { get; set; }

        protected override void OnInitialized()
        {
 
                Userslist = UserDataService.GetAllUsers();
                Roleslist = RoleDataService.GetAllRoles();
                Noteslist = NoteDataService.GetAllNotes();
                Customerslist = CustomerDataService.GetAllCustomers();
                TicketTypeslist = TicketTypeDataService.GetAllTicketTypes();

        }

        public void RefreshGrid()
        {
            OnInitialized();
        }
        void OnRowUpdating(DataAccess.Models.TicketType x, Dictionary<string, object> newValue)
        {
            TicketTypeDataService.UpdateTicketType(x, newValue);
            InvokeAsync(StateHasChanged);
        }
        void OnRowRemoving(DataAccess.Models.TicketType x)
        {
            TicketTypeDataService.DeleteTicketType(x.TicketTypeId);
            OnInitialized();
            InvokeAsync(StateHasChanged);
        }
        void OnRowInserting(Dictionary<string, object> newValue)
        {
            var x = new DataAccess.Models.TicketType();
            TicketTypeDataService.AddTicketType(TicketTypeDataService.UpdateTicketType(x, newValue));
            OnInitialized();
            InvokeAsync(StateHasChanged);
        }
        public void ClosePopup()
        {
            OnInitialized();
            PopupVisible = false;
        }


        //public async Task<IEnumerable<User>> OurUsers(CancellationToken ct = default)
        //{
        //    return await UserDataService.GetAllUsers();
        //}
    }
}
