using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TicketsApp.Services;

namespace TicketsApp.Pages.Ticket
{
    public partial class TicketList
    {
        [Inject]
        private TicketDataService TicketDataService { get; set; }

        List<DataAccess.Models.Ticket> EmpObj;
        protected override async Task OnInitializedAsync()
        {
            EmpObj = await TicketDataService.GetAllTickets();
        }
    }
}
