using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Components;
using TicketsApp.Services;

namespace TicketsApp.Pages.Ticket
{
    public partial class TicketAdd
    {
        [Inject]
        private TicketDataService TicketDataService { get; set; }
        [Inject]
        private UserDataService UserDataService { get; set; }
        [Inject]
        private CustomerDataService CustomerDataService { get; set; }

        public List<Customer> Customers { get; set; }
        public List<User> Users { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Users = await UserDataService.GetAllUsers();
            Customers = await CustomerDataService.GetAllCustomers();
        }

        [Inject]
        NavigationManager NavigationManager { get; set; }
        DataAccess.Models.Ticket obj = new DataAccess.Models.Ticket();
        protected async void CreateTicket()
        {
            await TicketDataService.AddTicket(obj);
            NavigationManager.NavigateTo("Tickets");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("Tickets");
        }
    }
}
