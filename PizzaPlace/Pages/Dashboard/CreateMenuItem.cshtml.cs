using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System;

namespace PizzaPlace.Pages.Dashboard
{
    [Authorize(Roles = "Admin")]
    public class CreateMenuItemModel : PageModel
    {
        private readonly IMenuItemService menuItemService;

        public CreateMenuItemModel(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }
        [BindProperty]
        public MenuViewModel MenuItem { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                MenuItem menuItem = new MenuItem() 
                {
                    Title = MenuItem.Title,
                    ImageUrl = MenuItem.ImageUrl,
                    Description = MenuItem.Description,
                    Price = MenuItem.Price,
                    DateCreated = DateTime.Now,
                };
                menuItemService.Add(menuItem);
                return RedirectToPage("MenuItemsList");
            }
            else
            {
                return Page();
            }
        }
    }
}