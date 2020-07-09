using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Custom;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages.Dashboard
{
    [Authorize(Roles = "Admin")]
    public class EditOfferModel : PageModel
    {
        private readonly IOfferService offerService;

        public EditOfferModel(IOfferService offerService)
        {
            this.offerService = offerService;
        }
        [BindProperty]
        public OfferViewModel Offer { get; set; }
        public void OnGet(int id)
        {
            Offer = ModelConverter.ConvertToOfferViewModel(offerService.GetById(id));
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Offer offer = ModelConverter.ConvertFromOfferViewModel(Offer);
                offerService.Update(offer);
                return RedirectToPage("OffersList");
            }
            else
            {
                return Page();
            }
        }
    }
}