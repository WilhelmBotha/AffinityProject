using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AffinityProject.Interfaces;
using AffinityProject.ViewModels;
using DataContext.Models;

namespace AffinityProject.Services
{
    public class OrderService : IOrderService
    {
        private AffinityContext _dataContext;

        public OrderService(AffinityContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<OrderViewModel> CreateOrder(OrderViewModel order)
        {
            try
            {
                var orderToAdd = new Order
                {
                    OrderDate = order.OrderDate,
                    OrderDetail = new OrderDetail
                    {
                        ItemDescription = order.ItemDescription,
                        Price = order.Price,
                        Quantity = order.Quantity
                    }
                };

                _dataContext.Order.Add(orderToAdd);
                _dataContext.SaveChanges();

                var orders = _dataContext.Order.Select(x => new OrderViewModel
                {
                    Id = x.Id,
                    CustomerName = x.Customer.Name,
                    ItemDescription = x.OrderDetail.ItemDescription,
                    OrderDate = x.OrderDate,
                    Price = x.OrderDetail.Price,
                    Quantity = x.OrderDetail.Quantity
                });

                return orders;

            }
            catch (Exception)
            {
                return new List<OrderViewModel>();
            }
        }

        public IEnumerable<OrderViewModel> DeleteOrder(int orderId)
        {
            try
            {
                var dbOrder = _dataContext.OrderDetail.Find(orderId);
                _dataContext.Remove(dbOrder);

                var orders = _dataContext.Order.Select(x => new OrderViewModel
                {
                    Id = x.Id,
                    CustomerName = x.Customer.Name,
                    ItemDescription = x.OrderDetail.ItemDescription,
                    OrderDate = x.OrderDate,
                    Price = x.OrderDetail.Price,
                    Quantity = x.OrderDetail.Quantity
                });

                return orders;
            }
            catch (Exception e)
            {
                return new List<OrderViewModel>();
            }
        }

        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            try
            {
                var orders = _dataContext.Order.Select(x => new OrderViewModel
                {
                    Id = x.Id,
                    CustomerName = x.Customer.Name,
                    ItemDescription = x.OrderDetail.ItemDescription,
                    OrderDate = x.OrderDate,
                    Price = x.OrderDetail.Price,
                    Quantity = x.OrderDetail.Quantity
                });

                return orders;
            }
            catch (Exception e)
            {
                return new List<OrderViewModel>();
            }
        }

        public IEnumerable<OrderViewModel> UpdateOrder(OrderViewModel updatedOrder)
        {
            try
            {
                var dbOrder = _dataContext.Order.Find(updatedOrder.Id);

                dbOrder.OrderDate = updatedOrder.OrderDate;
                dbOrder.OrderDetail.ItemDescription = updatedOrder.ItemDescription;
                dbOrder.OrderDetail.Price = updatedOrder.Price;
                dbOrder.OrderDetail.Quantity = updatedOrder.Quantity;

                _dataContext.Order.Update(dbOrder);

                var orders = _dataContext.Order.Select(x => new OrderViewModel
                {
                    Id = x.Id,
                    CustomerName = x.Customer.Name,
                    ItemDescription = x.OrderDetail.ItemDescription,
                    OrderDate = x.OrderDate,
                    Price = x.OrderDetail.Price,
                    Quantity = x.OrderDetail.Quantity
                });

                return orders;
            }
            catch (Exception)
            {
                return new List<OrderViewModel>();
            }
        }
    }
}
