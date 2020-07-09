using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Custom;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Pages.Dashboard
{
    public class FeedbacksListModel : PageModel
    {
        private readonly IFeedbackService feedbackService;

        public FeedbacksListModel(IFeedbackService feedbackService)
        {
            this.feedbackService = feedbackService;
        }
        public List<FeedbackViewModel> Feedbacks { get; set; }
        public void OnGet()
        {
            Feedbacks = feedbackService.GetAll()
                .Select(x => ModelConverter.ConvertToFeedbackViewModel(x))
                .ToList();
        }
    }
}