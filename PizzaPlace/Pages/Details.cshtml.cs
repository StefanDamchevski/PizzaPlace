using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IMenuItemService menuItemService;

        public DetailsModel(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }
        public MenuViewModel MenuViewModel { get; set; }
        public void OnGet(int id)
        {
            MenuItem menuItem = menuItemService.GetById(id);
            MenuViewModel = new MenuViewModel()
            {
                Id = menuItem.Id,
                Title = menuItem.Title,
                Description = menuItem.Description,
                DateCreated = menuItem.DateCreated,
                Price = menuItem.Price,
                ImageUrl = menuItem.ImageUrl
            };
        }
    }
}