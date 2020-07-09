using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaPlace.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public void Add(Order order)
        {
            order.IsProccessed = false;
            order.IsDelivered = false;
            orderRepository.Add(order);
        }

        public List<Order> GetAll()
        {
            return orderRepository.GetAll();
        }

        public List<Order> GetByStatus(bool isProccessed, bool isDelivered)
        {
            return orderRepository.GetByStatus(isProccessed, isDelivered);
        }

        public void SetOrderDelivered(int id)
        {
            Order order = orderRepository.GetById(id);
            order.IsDelivered = true;
            orderRepository.Update(order);
        }

        public void SetOrderProccessed(int id)
        {
            Order order = orderRepository.GetById(id);
            order.IsProccessed = true;
            orderRepository.Update(order);
        }
    }
}