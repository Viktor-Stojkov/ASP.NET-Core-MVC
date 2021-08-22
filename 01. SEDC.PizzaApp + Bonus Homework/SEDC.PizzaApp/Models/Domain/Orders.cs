using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Orders
    {
        public int Id { get; set; }
        public string NameOfCompany { get; set; }
        public string NameOfProduct { get; set; }
        public double Price { get; set; }
        public bool OnAction { get; set; }
    }
}
