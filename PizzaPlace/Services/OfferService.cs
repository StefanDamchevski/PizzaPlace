using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaPlace.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository offerRepository;

        public OfferService(IOfferRepository offerRepository)
        {
            this.offerRepository = offerRepository;
        }

        public void Create(Offer offer)
        {
            offerRepository.Add(offer);
        }

        public List<Offer> GetAll()
        {
            return offerRepository.GetAll();
        }

        public Offer GetById(int id)
        {
            return offerRepository.GetById(id);
        }

        public void Remove(int id)
        {
            offerRepository.Remove(id);
        }

        public void Update(Offer offer)
        {
            Offer dbOffer = offerRepository.GetById(offer.Id);
            if(dbOffer != null)
            {
                dbOffer.Title = offer.Title;
                dbOffer.Description = offer.Description;
                dbOffer.Price = offer.Price;
                offerRepository.Update(dbOffer);
            }
        }
    }
}
