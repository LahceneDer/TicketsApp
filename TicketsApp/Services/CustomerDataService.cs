using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DataAccess.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace TicketsApp.Services
{
    public class CustomerDataService 
    {
        private readonly ApplicationDbContext _appContext;

        public CustomerDataService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }

        public Customer AddCustomer(Customer customer)
        {
            _appContext.Customers.Add(customer);
            _appContext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(int customerId)
        {
            try
            {
                var c = _appContext.Customers.Find(customerId);
                _appContext.Customers.Remove(c);
                _appContext.SaveChanges();
            }
            catch 
            {
                
            }
        }


        public List<Customer> GetAllCustomers()
        {
            var customers = _appContext.Customers.ToList();
            return customers;
        }

        public Customer GetCustomerDetails(long customerId)
        {
            return _appContext.Customers.Find(customerId);
        }

        public Customer UpdateCustomer(Customer customer, Dictionary<string, object> newValue)
        {
            foreach (var field in newValue.Keys)
            {
                switch (field)
                {
                    case "CustomerName":
                        customer.CustomerName = (string)newValue[field];
                        break;
                    case "ReferenceInterne":
                        customer.ReferenceInterne = (int)newValue[field];
                        break;
                    case "CustomerId":
                        customer.CustomerId = (int)newValue[field];
                        break;
                    //case "UserId":
                    //    customer.UserId = (int)newValue[field];
                    //    break;
                    case "Telephone":
                        customer.Telephone = (string)newValue[field];
                        break;
                    case "Courriel":
                        customer.Courriel = (string)newValue[field];
                        break;
                    case "SiteWeb":
                        customer.SiteWeb = (string)newValue[field];
                        break;
                    case "Mobile":
                        customer.Mobile = (string)newValue[field];
                        break;
                    case "PosteOccupe":
                        customer.PosteOccupe = (string)newValue[field];
                        break;
                    case "TVA":
                        customer.TVA = (string)newValue[field];
                        break;

                }
            }
            _appContext.SaveChanges();
            return customer;
        }
    }
}
