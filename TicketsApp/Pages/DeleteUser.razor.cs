using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using TicketsApp.Services;

namespace TicketsApp.Pages
{
    public partial class DeleteUser
    {
        [Inject]
        private UserDataService UserDataService { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string userId { get; set; }
        User obj = new User();
        protected override async Task OnInitializedAsync()
        {
            obj = await UserDataService.GetUserDetails(Convert.ToInt32(userId));
        }
        protected async void UserDelete()
        {
            await UserDataService.DeleteUser(obj);
            NavigationManager.NavigateTo("Users");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("Users");
        }
    }
}
