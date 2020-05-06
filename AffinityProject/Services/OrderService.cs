using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AffinityProject.Interfaces;
using AffinityProject.ViewModels;
using DataContext.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AffinityProject.Services
{
    public class OrderService : IOrderService
    {
        private AffinityContext _dataContext;

        public OrderService(AffinityContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<OrderViewModel>> CreateOrder(OrderViewModel order)
        {
            try
            {
                var orderToAdd = new Order
                {
                    CustomerId = order.CustomerId,
                    OrderDate = order.OrderDate,
                    OrderDetail = new OrderDetail
                    {
                        ItemDescription = order.ItemDescription,
                        Price = order.Price,
                        Quantity = order.Quantity
                    }
                };

                _dataContext.Order.Add(orderToAdd);
                await _dataContext.SaveChangesAsync();

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

        public async Task<IEnumerable<OrderViewModel>> DeleteOrder(int orderId)
        {
            try
            {
                var dbOrder = _dataContext.Order.Include("OrderDetail").FirstOrDefault(x => x.Id == orderId);
                _dataContext.Remove(dbOrder.OrderDetail);
                _dataContext.Remove(dbOrder);
                await _dataContext.SaveChangesAsync();

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

        public OrderViewModel GetOrder(int id)
        {
            OrderViewModel orderVm;
            var customerList = _dataContext.Customer.ToList();

            var selectList = new List<SelectListItem>();

            customerList.ForEach(x => selectList.Add(new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }));

            if (id == 0)
            {
               
                orderVm = new OrderViewModel
                {
                    CustomerId = 0,
                    CustomerName = string.Empty,
                    Id = id,
                    ItemDescription = string.Empty,
                    OrderDate = DateTime.Now,
                    Price = 0,
                    Quantity = 0,
                    AvailableCustomers = selectList
                };
            }
            else
            {
                var dbOrder = _dataContext.Order.Include("OrderDetail").FirstOrDefault(x => x.Id == id);
                orderVm = new OrderViewModel
                {
                    CustomerId = dbOrder.CustomerId.Value,
                    CustomerName = dbOrder.Customer.Name,
                    Id = dbOrder.Id,
                    ItemDescription = dbOrder.OrderDetail.ItemDescription,
                    OrderDate = dbOrder.OrderDate,
                    Price = dbOrder.OrderDetail.Price,
                    Quantity = dbOrder.OrderDetail.Quantity,
                    AvailableCustomers = selectList
                };
            }
            
            return orderVm;
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

        public async Task<IEnumerable<OrderViewModel>> UpdateOrder(OrderViewModel updatedOrder)
        {
            try
            {
                var dbOrder = _dataContext.Order.Include("OrderDetail").FirstOrDefault(x => x.Id == updatedOrder.Id);

                dbOrder.OrderDate = updatedOrder.OrderDate;
                dbOrder.OrderDetail.ItemDescription = updatedOrder.ItemDescription;
                dbOrder.OrderDetail.Price = updatedOrder.Price;
                dbOrder.OrderDetail.Quantity = updatedOrder.Quantity;

                _dataContext.Order.Update(dbOrder);
                await _dataContext.SaveChangesAsync();
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
    }
}
