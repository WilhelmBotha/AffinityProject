using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerImport.Interfaces;
using DataContext.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CustomerImport.Services
{
    public class CustomerImportService : ICustomerImport
    {
        private readonly AffinityContext _context;

        public CustomerImportService(AffinityContext context)
        {
            _context = context;
        }

        public void ImportCustomer(IFormCollection file)
        {
            try
            {
                var csv = file.Files.FirstOrDefault();
                var customers = csv.ReadAsList();
                List<Customer> customersToAdd = new List<Customer>();

                customers.ForEach(x => customersToAdd.Add(new Customer
                {
                    Name = x
                }));

                _context.Customer.AddRange(customersToAdd);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<Customer> LoadCustomers()
        {
            var dbCustomers = _context.Customer.Include("Order").ToList();

            return dbCustomers;
        }

        
    }
}
