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
namespace TicketsApp.Pages.Customer
{
    public partial class CustomersList
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

        public ApplicationDbContext db { get; set; }

        public List<User> Userslist { get; set; }
        public List<DataAccess.Models.Role> Roleslist { get; set; }
        public List<Note> Noteslist { get; set; }
        public List<DataAccess.Models.Customer> Customerslist { get; set; }
        public List<DataAccess.Models.Ticket> Ticketslist { get; set; }
        public int userId { get; set; } = 0;
        private bool PopupVisible { get; set; }

        protected override void OnInitialized()
        {
            Userslist = UserDataService.GetAllUsers();
                Roleslist = RoleDataService.GetAllRoles();
                Noteslist = NoteDataService.GetAllNotes();
                Customerslist = CustomerDataService.GetAllCustomers();
        }

        public void RefreshGrid()
        {
            OnInitialized();
        }
        void OnRowUpdating(DataAccess.Models.Customer x, Dictionary<string, object> newValue)
        {
            CustomerDataService.UpdateCustomer(x, newValue);
            InvokeAsync(StateHasChanged);
        }
        void OnRowRemoving(DataAccess.Models.Customer x)
        {
            CustomerDataService.DeleteCustomer(x.CustomerId);
            OnInitialized();
            InvokeAsync(StateHasChanged);
        }
        void OnRowInserting(Dictionary<string, object> newValue)
        {
            var x = new DataAccess.Models.Customer();
            CustomerDataService.AddCustomer(CustomerDataService.UpdateCustomer(x, newValue));
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
