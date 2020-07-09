using PizzaPlace.Models;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Custom
{
    public static class ModelConverter
    {
        public static OrderViewModel ConvertToOrderViewModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                Address = order.Address,
                Name = order.Name,
                Phone = order.Phone,
                Surname = order.Surname,
                Message = order.Message,
                IsProccessed = order.IsProccessed,
                IsDelivered = order.IsDelivered,
            };
        }

        public static OfferViewModel ConvertToOfferViewModel(Offer offer)
        {
            return new OfferViewModel
            {
                Id = offer.Id,
                Title = offer.Title,
                Description = offer.Description,
                Price = offer.Price,
                DateCreated = offer.DateCreated,
            };
        }

        public static FeedbackViewModel ConvertToFeedbackViewModel(Feedback x)
        {
            return new FeedbackViewModel
            {
                EmailAdress = x.EmailAdress,
                Name = x.Name,
                Surname = x.Surname,
                Message = x.Message,
            };
        }

        public static MenuItem ConverFromMenuItemsModel(MenuViewModel menuItem)
        {
            return new MenuItem
            {
                Id = menuItem.Id,
                Title = menuItem.Title,
                Description = menuItem.Description,
                ImageUrl = menuItem.ImageUrl,
                DateCreated = menuItem.DateCreated,
                Price = menuItem.Price,
            };
        }

        public static MenuViewModel ConvertToMenuItemsModel(MenuItem x)
        {
            return new MenuViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                DateCreated = x.DateCreated,
                Price = x.Price,
            };
        }

        public static Offer ConvertFromOfferViewModel(OfferViewModel model)
        {
            return new Offer
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Price = model.Price,
                DateCreated = model.DateCreated,
            };
        }
    }
}
