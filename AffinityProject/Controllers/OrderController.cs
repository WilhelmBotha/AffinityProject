using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AffinityProject.Models;
using AffinityProject.ViewModels;
using AffinityProject.Interfaces;

namespace AffinityProject.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Orders()
        {
            ViewData["Title"] = "Orders";
            ViewData["Message"] = "List of orders";
            var orders = _orderService.GetAllOrders();
            return View(orders);
        }

        [HttpPost]
        public IActionResult UpdateOrder()
        {
            //var orders = _orderService.UpdateOrder();
            return View(new List<OrderViewModel>());
        }

        [HttpGet]
        public IActionResult AddOrUpdate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrUpdate([Bind("CustomerId, ItemDescription, OrderDate, Price, Quantity")] OrderViewModel order)
        {
            if (ModelState.IsValid)
            {
                _orderService.CreateOrder(order);
                return RedirectToAction(nameof(Orders));
            }
           
            return View(order);
        }

        public IActionResult DeleteOrder()
        {
            //var orders = _orderService.DeleteOrder(orderId);
            //return View(orders);
            return null;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
