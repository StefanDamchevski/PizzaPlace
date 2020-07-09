using PizzaPlace.Models;
using System.Collections.Generic;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface IOfferRepository
    {
        List<Offer> GetAll();
        void Remove(int id);
        void Add(Offer offer);
        Offer GetById(int id);
        void Update(Offer offer);
    }
}