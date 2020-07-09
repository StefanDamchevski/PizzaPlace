using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Custom;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Pages
{
    [Authorize]
    public class ViewOrdersModel : PageModel
    {
        private readonly IOrderService orderService;

        public ViewOrdersModel(IOrderService orderService)
        {
            this.orderService = orderService;
        }
        public List<OrderViewModel> Orders { get; set; }
        public void OnGet()
        {
            Orders = orderService.GetAll()
                .Select(x => ModelConverter.ConvertToOrderViewModel(x))
                .ToList();
        }
        public void OnGetNotProcessed()
        {
            Orders = orderService.GetByStatus(false, false)
                .Select(x => ModelConverter.ConvertToOrderViewModel(x))
                .ToList();
        }

        public void OnGetProcessed()
        {
            Orders = orderService.GetByStatus(true, false)
                .Select(x => ModelConverter.ConvertToOrderViewModel(x))
                .ToList();
        }
        public void OnGetDone()
        {
            Orders = orderService.GetByStatus(true, true)
                .Select(x => ModelConverter.ConvertToOrderViewModel(x))
                .ToList();
        }
        public IActionResult OnGetSetProcessed(int id)
        {
            orderService.SetOrderProccessed(id);
            return RedirectToPage("OrdersList", "NotProcessed");
        }
        public IActionResult OnGetSetDelivered(int id)
        {
            orderService.SetOrderDelivered(id);
            return RedirectToPage("OrdersList", "Processed");
        }
    }
}