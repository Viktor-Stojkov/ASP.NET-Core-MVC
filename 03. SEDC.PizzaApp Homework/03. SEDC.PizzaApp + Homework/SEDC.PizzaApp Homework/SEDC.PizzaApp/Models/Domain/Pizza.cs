using SEDC.PizzaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public PizzaSize PizzaSize { get; internal set; }
        public bool IsOnPromotion { get; set; }  //I will use the same prop for Homework
    }
}
