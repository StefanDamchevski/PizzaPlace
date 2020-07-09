using PizzaPlace.Models;
using System.Collections.Generic;

namespace PizzaPlace.Services.Interfaces
{
    public interface IOrderService
    {
        void Add(Order order);
        List<Order> GetAll();
        void SetOrderProccessed(int id);
        List<Order> GetByStatus(bool isProccessed, bool isDelivered);
        void SetOrderDelivered(int id);
    }
}
