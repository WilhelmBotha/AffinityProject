using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AffinityProject.ViewModels;
using DataContext.Models;

namespace AffinityProject.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderViewModel> CreateOrder(OrderViewModel order);
        IEnumerable<OrderViewModel> GetAllOrders();
        IEnumerable<OrderViewModel> UpdateOrder(OrderViewModel order);
        IEnumerable<OrderViewModel> DeleteOrder(int orderId);
    }
}
