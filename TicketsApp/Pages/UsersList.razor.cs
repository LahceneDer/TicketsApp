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
namespace TicketsApp.Pages
{
    public partial class UsersList
    {
        [Inject] 
        private UserDataService UserDataService { get; set; }
        [Inject]
        private RoleDataService RoleDataService { get; set; }

        public ApplicationDbContext db { get; set; }

        public List<User> Userslist { get; set; }
        public List<Role> Roleslist { get; set; }
        public int userId { get; set; } = 0;
        private bool PopupVisible { get; set; }

        public string newPassword { get; set; }
        public string confirmedPassword { get; set; }
        protected override void OnInitialized()
        {
            if (CheckPermissionService.CheckAutorisation(Action.Utilisateurs, Resource.Parametrage))
            {
                db = new ApplicationDbContext();
                Userslist = UserDataService.GetAllUsers();
                Roleslist = RoleDataService.GetAllRoles();  
                //base.OnInitialized();
            }
            else
            {
                JSRuntime.InvokeAsync<object>("open", "/NoAccess/", "_self");
            }
        }

        public void RefreshGrid()
        {
            OnInitialized();
        }
        void OnRowUpdating(User x, Dictionary<string, object> newValue)
        {
            UserDataService.UpdateUser(x, newValue);
            InvokeAsync(StateHasChanged);
        }
        void OnRowRemoving(User x)
        {
            UserDataService.DeleteUser(x.UserId);
            OnInitialized();
            InvokeAsync(StateHasChanged);
        }
        void OnRowInserting(Dictionary<string, object> newValue)
        {
            var x = new User();
            x.UserPassword = Hlp.GetSha1((string)newValue["UserName"], "QSDFGHJKLM@&987654321", "pass");
            UserDataService.AddUser(UserDataService.UpdateUser(x, newValue));
            OnInitialized();
            InvokeAsync(StateHasChanged);
        }
        public void ClosePopup()
        {
            OnInitialized();
            PopupVisible = false;
        }
        public void ChangePassword(User user)
        {
            PopupVisible = true;
            userId = user.UserId;
        }
        public void SaveNewPassword()
        {
            if (newPassword == confirmedPassword)
            {
                UserDataService.SaveNewPassword(userId, newPassword);
            }
        }


        //public async Task<IEnumerable<User>> OurUsers(CancellationToken ct = default)
        //{
        //    return await UserDataService.GetAllUsers();
        //}
    }
}
