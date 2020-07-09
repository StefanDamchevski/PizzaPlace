using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System;

namespace PizzaPlace.Pages
{
    public class FeedbackModel : PageModel
    {
        private readonly IFeedbackService feedbackService;

        public FeedbackModel(IFeedbackService feedbackService)
        {
            this.feedbackService = feedbackService;
        }
        [BindProperty]
        public FeedbackViewModel Feedback { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Feedback feedback = new Feedback()
                {
                    Name = Feedback.Name,
                    Surname = Feedback.Surname,
                    EmailAdress = Feedback.EmailAdress,
                    Message = Feedback.Message,
                    DateCreated = DateTime.Now,
                };

                feedbackService.Add(feedback);

                return RedirectToPage("Confirmation", "Feedback");
            }
            else
            {
                return Page();
            }
        }
    }
}