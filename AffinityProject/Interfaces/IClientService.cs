using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AffinityProject.ViewModels;

namespace AffinityProject.Interfaces
{
    public interface IClientService
    {
        IEnumerable<CustomerViewModel> GetAllClients();
    }
}
