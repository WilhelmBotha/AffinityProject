using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataContext.Models;
using Microsoft.AspNetCore.Http;

namespace CustomerImport.Interfaces
{
    public interface ICustomerImport
    {
        void ImportCustomer(IFormCollection file);
        IEnumerable<Customer> LoadCustomers();
    }
}
