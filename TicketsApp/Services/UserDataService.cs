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
    public class UserDataService 
    {
        private readonly ApplicationDbContext _appContext;

        public UserDataService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }


        public User AddUser(User user)
        {
            _appContext.Users.Add(user);
            _appContext.SaveChanges();
            return user;
        }

        public void DeleteUser(int userId)
        {
            var c = _appContext.Users.Find(userId);
            _appContext.Users.Remove(c);
            _appContext.SaveChanges();
        }


        public   List<User> GetAllUsers()
        {
            var users = _appContext.Users.ToList();
            return users;
        }

        public  User GetUserDetails(long userId)
        {
            return _appContext.Users.Find(userId);
        }






        public User UpdateUser(User user, Dictionary<string, object> newValue)
        {
            foreach (var field in newValue.Keys)
            {
                switch (field)
                {
                    case "UserId":
                        user.UserId = (int)newValue[field];
                        break;
                    case "UserName":
                        user.UserName = (string)newValue[field];
                        break;
                    case "UserAdresse":
                        user.UserAdresse = (string)newValue[field];
                        break;
                    case "UserPrenom":
                        user.UserPrenom = (string)newValue[field];
                        break;
                    case "UserNom":
                        user.UserNom = (string)newValue[field];
                        break;
                    case "UserTelFixe":
                        user.UserTelFixe = (string)newValue[field];
                        break;
                    case "UserTelMob":
                        user.UserTelMob = (string)newValue[field];
                        break;
                    case "UserFax":
                        user.UserFax = (string)newValue[field];
                        break;
                    case "UserEmail":
                        user.UserEmail = (string)newValue[field];
                        break;
                    case "UserMaxCapacity":
                        user.UserMaxCapacity = Convert.ToInt32(newValue[field]);
                        break;
                    //case "UserPassword":
                    //    var u = (string) newValue["UserName"];
                    //    user.UserPassword = Hlp.GetSha1(u, "QSDFGHJKLM@&987654321", (string)newValue[field]);
                    //    break;
                    case "UserDescript":
                        user.UserDescript = (string)newValue[field];
                        break;
                    case "RoleID":
                        user.RoleID = (int?)newValue[field];
                        break;
                    case "WilayaId":
                        user.WilayaId = (int)newValue[field];
                        break;
                    case "CommuneId":
                        user.CommuneId = (int)newValue[field];
                        break;

                    case "ServiceID":
                        user.ServiceID = (int)newValue[field];
                        break;

                    case "SpecialiteID":
                        user.SpecialiteID = (int)newValue[field];
                        break;

                    case "UserDateNaiss":
                        user.UserDateNaiss = (DateTime)newValue[field];
                        break;
                }
            }
            _appContext.SaveChanges();
            return user;
        }
        public void SaveNewPassword(int uId, string password)
        {
            var user = _appContext.Users.Find(uId);
            user.UserPassword = Hlp.GetSha1(user.UserName, "QSDFGHJKLM@&987654321", password);
            user.PasswordChanged = true;
            _appContext.SaveChanges();
        }

    }
}
