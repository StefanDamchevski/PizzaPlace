using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaPlace.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository feedbackRepository;

        public FeedbackService(IFeedbackRepository feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }
        public void Add(Feedback feedback)
        {
            feedbackRepository.Add(feedback);
        }

        public List<Feedback> GetAll()
        {
            return feedbackRepository.GetAll();
        }
    }
}
