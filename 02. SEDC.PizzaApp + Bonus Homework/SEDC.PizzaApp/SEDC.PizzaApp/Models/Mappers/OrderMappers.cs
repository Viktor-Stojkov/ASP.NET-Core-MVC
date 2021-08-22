using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Domain.Mappers
{
    public static class OrderMappers
    {
        public static OrderDetailsViewModel OrderToOrderDetailsViewModel(Order order)
        {
            return new OrderDetailsViewModel
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.IsOnPromotion ? 300 : order.Pizza.Price, // calculation for discount
                UserAddress = order.User.Address  // New prop for PizzaApp Homework
            };
        }

        public static OrderListViewModels OrderToOrderListVIewModel(Order order)
        {
            return new OrderListViewModels
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}"
            };
        }
    }
}
