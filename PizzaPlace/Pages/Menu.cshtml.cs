using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Pages
{
    public class MenuModel : PageModel
    {
        private readonly IMenuItemService menuItemService;

        public MenuModel(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }
        public List<MenuViewModel> MenuViewModels { get; set; }
        public void OnGet()
        {
            MenuViewModels = menuItemService.GetAll().Select(x => new MenuViewModel 
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                DateCreated = x.DateCreated,
            }).ToList();
        }
    }
}