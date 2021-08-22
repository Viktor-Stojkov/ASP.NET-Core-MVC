using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp
{
    public static class StaticOrdersDb
    {
        public static List<Orders> OrderStatic = new List<Orders>
        {
            new Orders
            {
                Id = 1,
                NameOfCompany = "Milka.Doo",
                NameOfProduct = "Milka Chocolate",
                Price = 35,
                OnAction = true
            },

            new Orders
            {
                Id = 2,
                NameOfCompany = "Dorina.Doo",
                NameOfProduct = "Dorina Chocolate",
                Price = 45,
                OnAction = false
            },

            new Orders
            {
                Id = 3,
                NameOfCompany = "Vitalia.Doo",
                NameOfProduct = "Healty Food",
                Price = 150,
                OnAction = false
            },

            new Orders
            {
                Id = 4,
                NameOfCompany = "Crash.Doo",
                NameOfProduct = "Chocolate Eggs",
                Price = 55,
                OnAction = false
            },

            new Orders
            {
                Id = 5,
                NameOfCompany = "Coca Cola.Doo",
                NameOfProduct = "Black Juice",
                Price = 45,
                OnAction = true
            },

            new Orders
            {
                Id = 6,
                NameOfCompany = "Dorina.Doo",
                NameOfProduct = "Buble Chocolate",
                Price = 45,
                OnAction = false
            }
        };
    }
}
