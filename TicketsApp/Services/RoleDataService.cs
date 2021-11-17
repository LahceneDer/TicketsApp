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
    public class RoleDataService
    {
        private readonly ApplicationDbContext _appContext;

        public RoleDataService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }


        public Role AddRole(Role role)
        {
            _appContext.Roles.Add(role);
            _appContext.SaveChanges();
            return role;
        }

        public void DeleteRole(int roleId)
        {
            var c = _appContext.Roles.Find(roleId);
            _appContext.Roles.Remove(c);
            _appContext.SaveChanges();
        }


        public   List<Role> GetAllRoles()
        {
            var roles = _appContext.Roles.ToList();
            return roles;
        }

        public  Role GetRoleDetails(long rolesId)
        {
            return _appContext.Roles.Find(rolesId);
        }






        public Role UpdateRole(Role role, Dictionary<string, object> newValue)
        {
            foreach (var field in newValue.Keys)
            {
                switch (field)
                {
                    case "TicketTypeId":
                        role.RoleId = (int)newValue[field];
                        break;
                    case "TicketTypeName":
                        role.RoleName = (string)newValue[field];
                        break;
                }
            }
            _appContext.SaveChanges();
            return role;
        }

    }
}
