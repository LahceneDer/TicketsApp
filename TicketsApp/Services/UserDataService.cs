using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace TicketsApp.Services
{
    public class UserDataService : IUserDataService
    {
        private readonly ApplicationDbContext _appContext;

        public UserDataService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<User> AddUser(User user)
        {
            await _appContext.Users.AddAsync(user);
            await _appContext.SaveChangesAsync();
            return user;
        }

        public async Task DeleteUser(User user)
        {
            _appContext.Remove(user);
            await _appContext.SaveChangesAsync();
        }

        public  async Task<List<User>> GetAllUsers()
        {
            return await _appContext.Users.ToListAsync();
        }

        public async Task<User> GetUserDetails(long userId)
        {
            User user = await _appContext.Users.FirstOrDefaultAsync(c => c.UserId.Equals(userId));
            return user;
        }

        public async Task UpdateUser(User user)
        {
            _appContext.Users.Update(user);
            await _appContext.SaveChangesAsync();
        }
    }
}
