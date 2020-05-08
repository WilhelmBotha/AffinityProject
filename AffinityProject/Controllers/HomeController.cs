using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AffinityProject.Models;
using CustomerImport.Interfaces;
using Microsoft.AspNetCore.Http;

namespace AffinityProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerImport _customerImport;

        public HomeController(ICustomerImport customerImport)
        {
            _customerImport = customerImport;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            if (ModelState.IsValid)
            {
                var form = await Request.ReadFormAsync();
                _customerImport.ImportCustomer(form);
            }

            return RedirectToAction("Clients", "Client");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
