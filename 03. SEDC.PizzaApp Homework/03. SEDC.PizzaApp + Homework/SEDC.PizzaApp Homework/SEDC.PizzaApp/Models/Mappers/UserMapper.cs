using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public class UserMapper 
    {
        public static UserViewModel UserToUserViewModel(User user)
        {
            return new UserViewModel
            {
                FullName = $"{user.FirstName} {user.LastName}",
            };
        }
    }
}
