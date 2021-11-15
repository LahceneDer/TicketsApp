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
    public class CustomerDataService : ICustomerDataService
    {
        private readonly ApplicationDbContext _appContext;

        public CustomerDataService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }

        public Task<Customer> AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _appContext.Customers.ToListAsync();
        }

        public Task<Customer> GetCustomerDetails(long customerId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
