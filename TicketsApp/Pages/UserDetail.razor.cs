using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Components;
using TicketsApp.Services;

namespace TicketsApp.Pages
{
    public partial class UserDetail : ComponentBase
    {
        [Parameter]
        public string UserId { get; set; }
        public User User { get; set; } = new User();
        [Inject]
        public IUserDataService UserDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            User = await UserDataService.GetUserDetails(int.Parse(UserId));
        }

    }
}
