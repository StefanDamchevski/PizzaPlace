using PizzaPlace.Models;
using System.Collections.Generic;

namespace PizzaPlace.Services.Interfaces
{
    public interface IOfferService
    {
        List<Offer> GetAll();
        void Remove(int id);
        void Create(Offer offer);
        Offer GetById(int id);
        void Update(Offer offer);
    }
}
