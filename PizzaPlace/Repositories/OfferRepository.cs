using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly PizzaPlaceDbContext context;

        public OfferRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void Add(Offer offer)
        {
            context.Offers.Add(offer);
            context.SaveChanges();
        }

        public List<Offer> GetAll()
        {
            return context.Offers.ToList();
        }

        public Offer GetById(int id)
        {
            return context.Offers.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            Offer offer = new Offer()
            {
                Id = id,
            };
            context.Offers.Remove(offer);
            context.SaveChanges();
        }

        public void Update(Offer offer)
        {
            context.Offers.Update(offer);
            context.SaveChanges();
        }
    }
}
