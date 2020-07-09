using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Custom;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Pages.Dashboard
{
    [Authorize(Roles = "Admin")]
    public class MenuItemsListModel : PageModel
    {
        private readonly IMenuItemService menuItemService;

        public MenuItemsListModel(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }
        public List<MenuViewModel> MenuItems { get; set; }
        public void OnGet()
        {
            MenuItems = menuItemService.GetAll()
                .Select(x => ModelConverter.ConvertToMenuItemsModel(x))
                .ToList();
        }
        public IActionResult OnGetDeleteMenuItem(int id)
        {
            menuItemService.Remove(id);
            return RedirectToPage("MenuItemsList");
        }
    }
}