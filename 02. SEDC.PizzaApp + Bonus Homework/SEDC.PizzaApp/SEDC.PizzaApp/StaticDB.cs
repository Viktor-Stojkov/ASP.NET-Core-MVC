using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp
{
    public static class StaticDB
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza
            {
                Id = 1,
                Name = "Capri",
                Price = 350,
                IsOnPromotion = true
            },

            new Pizza
            {
                Id = 2,
                Name = "Margarita",
                Price = 380,
                IsOnPromotion = false
            },

            // New action with arguments for homework, using new prop and old ( I am right with the words ? )
            new Pizza
            {
                Id = 3,
                Name = "BBQ Pizza",
                HasExtras = true,
                PizzaSize = Models.Enums.PizzaSize.Family,
                IsOnPromotion = true,
                Price = 400
            },

            new Pizza
            {
                Id = 4,
                Name = "Four type of Cheese Pizza",
                HasExtras = false,
                PizzaSize = Models.Enums.PizzaSize.Normal,
                IsOnPromotion = false,
                Price = 250
            }
        };

        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "Tanja",
                LastName = "Stojanovska",
                Address = "Adresa1"
            },

            new User
            {
                Id = 2,
                FirstName = "Aleksandar",
                LastName = "manasiev",
                Address = "Adresa2"
            }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                Pizza = Pizzas.First(),
                User = Users.First(),
                PaymentMethod = Models.Enums.PaymentMethod.Card
            },

            new Order
            {
                Id = 2,
                Pizza = Pizzas.Last(),
                User = Users.Last(),
                PaymentMethod = Models.Enums.PaymentMethod.Cash
            }
        };
    }
}
