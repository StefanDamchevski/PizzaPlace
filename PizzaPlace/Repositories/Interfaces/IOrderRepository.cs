using PizzaPlace.Models;
using System.Collections.Generic;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Add(Order order);
        List<Order> GetAll();
        Order GetById(int id);
        void Update(Order order);
        List<Order> GetByStatus(bool isProccessed, bool isDelivered);
    }
}
