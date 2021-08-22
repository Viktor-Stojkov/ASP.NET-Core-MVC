using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class PizzaOrderMappers
    {
        public static PizzaViewModel pizzaViewModel(Pizza pizza) 
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = $"{pizza.Name}",
                PizzaSize = pizza.PizzaSize,
                Price = pizza.HasExtras ? pizza.Price + 10 : pizza.Price // Check if Pizza HasExtras (true) add + 10, otherwiev print normal.
            };
        }
    }
}
