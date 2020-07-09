using PizzaPlace.Models;
using System.Collections.Generic;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface IFeedbackRepository
    {
        void Add(Feedback feedback);
        List<Feedback> GetAll();
    }
}
