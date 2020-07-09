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
    public class OffersListModel : PageModel
    {
        private readonly IOfferService offerService;

        public OffersListModel(IOfferService offerService)
        {
            this.offerService = offerService;
        }
        public List<OfferViewModel> Offers { get; set; }
        public void OnGet()
        {
            Offers = offerService.GetAll()
                .Select(x => ModelConverter.ConvertToOfferViewModel(x))
                .ToList();
        }
        public IActionResult OnGetDeleteOffer(int id)
        {
            offerService.Remove(id);
            return RedirectToPage("OffersList");
        }
    }
}