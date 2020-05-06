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

        [HttpGet]
        public IActionResult Orders()
        {
            ViewData["Title"] = "Orders";
            ViewData["Message"] = "List of orders";
            var orders = _orderService.GetAllOrders();
            return View(orders);
        }

        [HttpGet]
        public IActionResult AddOrUpdate(int id = 0)
        {
            ViewData["Title"] = id == 0 ? "Create" : "Update";
            return View(_orderService.GetOrder(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrUpdate([Bind("Id, CustomerId, ItemDescription, OrderDate, Price, Quantity")] OrderViewModel order)
        {
            if (ModelState.IsValid)
            {
                if (order.Id == 0)
                {
                   await _orderService.CreateOrder(order);
                }
                else
                {
                    await _orderService.UpdateOrder(order);
                }

                
                return RedirectToAction(nameof(Orders));
            }
           
            return View(order);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteOrder(int id = 0)
        {
            await _orderService.DeleteOrder(id);
            return RedirectToAction(nameof(Orders));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
