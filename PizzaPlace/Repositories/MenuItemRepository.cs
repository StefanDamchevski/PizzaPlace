using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly PizzaPlaceDbContext context;

        public MenuItemRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void Add(MenuItem menuItem)
        {
            context.MenuItems.Add(menuItem);
            context.SaveChanges();
        }

        public List<MenuItem> GetAll()
        {
            return context.MenuItems.ToList();
        }

        public MenuItem GetById(int id)
        {
            return context.MenuItems.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            MenuItem menuItem = new MenuItem() 
            {
                Id = id,
            };

            context.MenuItems.Remove(menuItem);
            context.SaveChanges();
        }

        public void Update(MenuItem dbMenuItem)
        {
            context.MenuItems.Update(dbMenuItem);
            context.SaveChanges();
        }
    }
}