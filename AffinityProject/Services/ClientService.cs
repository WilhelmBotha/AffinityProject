using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AffinityProject.Interfaces;
using AffinityProject.ViewModels;
using CustomerImport.Interfaces;

namespace AffinityProject.Services
{
    public class ClientService : IClientService
    {
        private readonly ICustomerImport _customerImport;

        public ClientService(ICustomerImport customerImport)
        {
            _customerImport = customerImport;
        }

        public IEnumerable<CustomerViewModel> GetAllClients()
        {
            var dbCustomers = _customerImport.LoadCustomers();

            var customers = dbCustomers.Select(x => new CustomerViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Orders = x.Order.Count
            });

            return customers;
        }
    }
}
