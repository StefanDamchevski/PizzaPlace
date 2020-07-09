using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IOfferService offerService;

        public IndexModel(IOfferService offerService)
        {
            this.offerService = offerService;
        }
        public List<OfferViewModel> OfferViewModels { get; set; }
        public void OnGet()
        {
            OfferViewModels = offerService.GetAll().Select(x => new OfferViewModel
            {
                Title = x.Title,
                Description = x.Description,
                DateCreated = x.DateCreated,
                Price = x.Price,
            }).ToList();

        }
    }
}