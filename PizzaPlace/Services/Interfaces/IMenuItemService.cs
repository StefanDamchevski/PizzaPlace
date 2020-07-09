using PizzaPlace.Models;
using System.Collections.Generic;

namespace PizzaPlace.Services.Interfaces
{
    public interface IMenuItemService
    {
        List<MenuItem> GetAll();
        MenuItem GetById(int id);
        void Remove(int id);
        void Add(MenuItem menuItem);
        void Update(MenuItem menuItem);
    }
}
