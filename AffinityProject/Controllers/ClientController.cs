using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AffinityProject.Models;
using AffinityProject.ViewModels;
using AffinityProject.Interfaces;
using CustomerImport.Interfaces;
using CustomerImport.Repositories;

namespace AffinityProject.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public IActionResult Clients()
        {
            ViewData["Title"] = "Clients";
            ViewData["Message"] = "List of clients";
            var clientList = _clientService.GetAllClients();
            return View(clientList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
