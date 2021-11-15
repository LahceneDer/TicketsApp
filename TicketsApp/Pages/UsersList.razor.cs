using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Components;
using TicketsApp.Services;

namespace TicketsApp.Pages
{
    public partial class UsersList
    {
        [Inject] 
        private UserDataService UserDataService { get; set; }

        List<User> EmpObj;
        protected override async Task OnInitializedAsync()
        {
            EmpObj = await UserDataService.GetAllUsers();
        }
    }
}
