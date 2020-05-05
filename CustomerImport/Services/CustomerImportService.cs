using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AffinityProject.Interfaces;
using DataContext.Models;

namespace AffinityProject.Services
{
    public class CustomerImportService : ICustomerImport
    {
        private readonly AffinityContext _context;

        public CustomerImportService(AffinityContext context)
        {
            _context = context;
        }

        public void ImportCustomer()
        {
            
        }

        public void LoadCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
