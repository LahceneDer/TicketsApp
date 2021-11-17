using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BM.Common.Help;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace TicketsApp.Services
{
    public class TicketTypeDataService
    {
        private readonly ApplicationDbContext _appContext;

        public TicketTypeDataService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }



        public TicketType AddTicketType(TicketType ticketType)
        {
            _appContext.TicketTypes.Add(ticketType);
            _appContext.SaveChanges();
            return ticketType;
        }

        public void DeleteTicketType(int ticketTypeId)
        {
            var c = _appContext.TicketTypes.Find(ticketTypeId);
            _appContext.TicketTypes.Remove(c);
            _appContext.SaveChanges();
        }


        public   List<TicketType> GetAllTicketTypes()
        {
            var ticketTypes = _appContext.TicketTypes.ToList();
            return ticketTypes;
        }

        public TicketType GetTicketTypeDetails(long ticketTypeId)
        {
            return _appContext.TicketTypes.Find(ticketTypeId);
        }






        public TicketType UpdateTicketType(TicketType ticketType, Dictionary<string, object> newValue)
        {
            foreach (var field in newValue.Keys)
            {
                switch (field)
                {
                    case "TicketTypeId":
                        ticketType.TicketTypeId = (int)newValue[field];
                        break;
                    case "TicketTypeName":
                        ticketType.TicketTypeName = (string)newValue[field];
                        break;
                }
            }
            _appContext.SaveChanges();
            return ticketType;
        }

    }
}
