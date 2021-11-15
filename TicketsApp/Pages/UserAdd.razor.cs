using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Components;
using TicketsApp.Services;
    


namespace TicketsApp.Pages
{
    public partial class UserAdd
    {
        [Inject]
        private UserDataService UserDataService { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }
        User obj = new User();
        protected async void CreateUser()
        {
            await UserDataService.AddUser(obj);
            NavigationManager.NavigateTo("Users");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("Users");
        }
    }
}
