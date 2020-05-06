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
        Task<IEnumerable<OrderViewModel>> CreateOrder(OrderViewModel order);
        IEnumerable<OrderViewModel> GetAllOrders();
        Task<IEnumerable<OrderViewModel>> UpdateOrder(OrderViewModel order);
        Task<IEnumerable<OrderViewModel>> DeleteOrder(int orderId);
        OrderViewModel GetOrder(int id);
    }
}
