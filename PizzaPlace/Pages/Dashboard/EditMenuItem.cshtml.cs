using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Custom;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages.Dashboard
{
    public class EditMenuItemModel : PageModel
    {
        private readonly IMenuItemService menuItemService;

        public EditMenuItemModel(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }
        [BindProperty]
        public MenuViewModel MenuItem { get; set; }
        public void OnGet(int id)
        {
            MenuItem = ModelConverter.ConvertToMenuItemsModel(menuItemService.GetById(id));
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                MenuItem menuItem = ModelConverter.ConverFromMenuItemsModel(MenuItem);
                menuItemService.Update(menuItem);
                return RedirectToPage("MenuItemsList");
            }
            else
            {
                return Page();
            }
        }
    }
}