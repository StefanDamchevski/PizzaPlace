using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaPlace.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository menuItemRepository;

        public MenuItemService(IMenuItemRepository menuItemRepository)
        {
            this.menuItemRepository = menuItemRepository;
        }

        public void Add(MenuItem menuItem)
        {
            menuItemRepository.Add(menuItem);
        }

        public List<MenuItem> GetAll()
        {
            return menuItemRepository.GetAll();
        }

        public MenuItem GetById(int id)
        {
            return menuItemRepository.GetById(id);
        }

        public void Remove(int id)
        {
            menuItemRepository.Remove(id);
        }

        public void Update(MenuItem menuItem)
        {
            MenuItem dbMenuItem = menuItemRepository.GetById(menuItem.Id);
            if(dbMenuItem != null)
            {
                dbMenuItem.Title = menuItem.Title;
                dbMenuItem.ImageUrl = menuItem.ImageUrl;
                dbMenuItem.Description = menuItem.Description;
                dbMenuItem.Price = menuItem.Price;

                menuItemRepository.Update(dbMenuItem);
            }
        }
    }
}
