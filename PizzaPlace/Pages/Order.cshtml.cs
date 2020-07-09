using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System;

namespace PizzaPlace.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService orderService;
        private readonly ISubscriptionService subscriptionService;

        public OrderModel(IOrderService orderService, ISubscriptionService subscriptionService)
        {
            this.orderService = orderService;
            this.subscriptionService = subscriptionService;
        }
        [BindProperty]
        public OrderViewModel Order { get; set; }
        public string ErrorMessage { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Order order = new Order()
                {
                    Name = Order.Name,
                    Address = Order.Address,
                    Surname = Order.Surname,
                    Phone = Order.Phone,
                    Message = Order.Message
                };

                orderService.Add(order);
                return RedirectToPage("Confirmation", "Order");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPostSubscribe(string email)
        {
            if (!String.IsNullOrEmpty(email))
            {
                subscriptionService.Add(email);
                return RedirectToPage("Confirmation", "Subscription");
            }
            else
            {
                ErrorMessage = "Please Enter Email";
                return Page();
            }
        }
    }
}