﻿using System;
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
namespace TicketsApp.Pages.Ticket
{
    public partial class TicketsList
    {
        [Inject] 
        private UserDataService UserDataService { get; set; }
        [Inject]
        private RoleDataService RoleDataService { get; set; }
        [Inject]
        private TicketDataService TicketDataService { get; set; }
        [Inject]
        private NoteDataService NoteDataService { get; set; }

        public ApplicationDbContext db { get; set; }

        public List<User> Userslist { get; set; }
        public List<Role> Roleslist { get; set; }
        public List<Note> Noteslist { get; set; }
        public List<DataAccess.Models.Ticket> Ticketslist { get; set; }
        public int userId { get; set; } = 0;
        private bool PopupVisible { get; set; }

        protected override void OnInitialized()
        {
 
                db = new ApplicationDbContext();
                Userslist = UserDataService.GetAllUsers();
                Roleslist = RoleDataService.GetAllRoles();
                Noteslist = NoteDataService.GetAllNotes();

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


        //public async Task<IEnumerable<User>> OurUsers(CancellationToken ct = default)
        //{
        //    return await UserDataService.GetAllUsers();
        //}
    }
}
