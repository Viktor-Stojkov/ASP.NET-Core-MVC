using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using SEDC.PizzaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public class PizzaMapper
    {
        public static PizzaViewModel PizzaToPizzaViewModel(Pizza pizza)
        {
            return new PizzaViewModel
            {
                Name = pizza.Name,
                Price = pizza.Price,
                IsPromotion = pizza.IsOnPromotion,
                PizzaSize = pizza.PizzaSize
            };
        }

        //public static PizzaListViewModel PizzaToPizzaViewModel(Pizza pizza)
        //{
        //    return new PizzaListViewModel()
        //    {
        //        PizzaName = pizza.Name,
        //        UserFullName =$"{pizza.FirstName} {pizza.LastName}",
        //        PizzaSize = PizzaSize.Normal,
        //        IsPromotion = pizza.IsOnPromotion
        //    };
        //}

        //public static PizzaDetailsViewModel PizzaToPizzaDetailsViewModel(Pizza pizza)
        //{
        //    return new PizzaDetailsViewModel()
        //    {
        //        Id = pizza.Id,
        //        PizzaName = pizza.Name,
        //        Name = pizza.Name,
        //        PizzaSize = pizza.PizzaSize,
        //        Price = pizza.Price,
        //        IsOnPromotion = pizza.IsOnPromotion
                
        //    };
        // }

    }
}
