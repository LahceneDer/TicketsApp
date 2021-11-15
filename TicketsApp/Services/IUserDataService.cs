using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;

namespace TicketsApp.Services
{
    public interface IUserDataService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserDetails(long userId);
        Task<User> AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(User user);

    }
}
