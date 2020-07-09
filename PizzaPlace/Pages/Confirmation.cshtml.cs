using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPlace.Pages
{
    public class ConfirmationModel : PageModel
    {
        public string Message { get; set; }
        public void OnGetOrder()
        {
            Message = "Thank you for ordering!!!";
        }
        public void OnGetSubscription()
        {
            Message = "Thanks for subscribing!!!";
        }
        public void OnGetFeedback()
        {
            Message = "Thanks for your feedback!!!";
        }
    }
}