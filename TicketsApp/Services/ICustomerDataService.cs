using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;

namespace TicketsApp.Services
{
    public interface ICustomerDataService
    {
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerDetails(long customerId);
        Task<Customer> AddCustomer(Customer customer);
        Task UpdateUser(Customer customer);
        Task DeleteUser(Customer customer);

    }
}
