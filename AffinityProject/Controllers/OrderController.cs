using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AffinityProject.Models;
using AffinityProject.ViewModels;

namespace AffinityProject.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Orders()
        {
            ViewData["Title"] = "Orders";
            ViewData["Message"] = "List of orders";

            return View(new List<OrderViewModel>());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
