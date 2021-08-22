using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Domain.Mappers;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            List<Order> ordersDB = StaticDB.Orders;
            List<OrderListViewModels> orderListViewModels = ordersDB
                .Select(x => OrderMappers.OrderToOrderListVIewModel(x)).ToList();   // Generic


            // LINQ

            //    List<OrderListViewModels> orderListViewModels = new List<OrderListViewModels>();
            //    foreach (Order orderDb in ordersDb)
            //    {
            //        orderListViewModels.Add(OrderMappers.OrderToOrderListVIewModel(orderDb));   
            //    }

            ViewData["Message"] = $"The number of orders is: {ordersDB.Count}";
            ViewData["Title"] = "Orders list";
            ViewData["Date"] = DateTime.Now.ToShortDateString();

            ViewData["FirstUser"] = StaticDB.Users.First();

            return View(orderListViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            ViewBag.Message = "You are on the order details page";
            ViewBag.User = StaticDB.Users.First();

            //orderDB -> Data Base
            Order orderDB = StaticDB.Orders.FirstOrDefault(x => x.Id == id);
            if (orderDB == null)
            {
                return new EmptyResult();
            }

            // view model -> date to the view
            OrderDetailsViewModel orderDetailsViewModel = OrderMappers.OrderToOrderDetailsViewModel(orderDB);
            return View(orderDetailsViewModel);
        }
    }
}
