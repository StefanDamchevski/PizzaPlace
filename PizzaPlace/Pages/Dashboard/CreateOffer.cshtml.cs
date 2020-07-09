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
    public class CreateOfferModel : PageModel
    {
        private readonly IOfferService offerService;

        public CreateOfferModel(IOfferService offerService)
        {
            this.offerService = offerService;
        }
        [BindProperty]
        public OfferViewModel Offer { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Offer offer = new Offer();
                offer.Title = Offer.Title;
                offer.Description = Offer.Description;
                offer.Price = Offer.Price;
                offer.DateCreated = DateTime.Now;

                offerService.Create(offer);
                return RedirectToPage("OffersList");
            }
            else
            {
                return Page();
            }
        }
    }
}