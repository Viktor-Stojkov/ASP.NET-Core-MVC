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
        public bool IsOnPromotion { get; set; }
        public Order Order{ get; set; }


        //For Homework Properties
        public double Price { get; set; }  // I will use the same Price prop from before
        public bool HasExtras { get; set; }
        public PizzaSize PizzaSize { get; set; }
    }
}
