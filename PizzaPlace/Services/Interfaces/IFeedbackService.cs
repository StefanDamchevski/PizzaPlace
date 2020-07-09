using PizzaPlace.Models;
using System.Collections.Generic;

namespace PizzaPlace.Services.Interfaces
{
    public interface IFeedbackService
    {
        void Add(Feedback feedback);
        List<Feedback> GetAll();
    }
}
