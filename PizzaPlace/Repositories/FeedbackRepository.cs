using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly PizzaPlaceDbContext context;

        public FeedbackRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void Add(Feedback feedback)
        {
            context.Feedbacks.Add(feedback);
            context.SaveChanges();
        }

        public List<Feedback> GetAll()
        {
            return context.Feedbacks.ToList();
        }
    }
}
