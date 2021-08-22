using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            List<Orders> orders = StaticOrdersDb.OrderStatic;
            return View(orders);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Orders order = StaticOrdersDb.OrderStatic.FirstOrDefault(x => x.Id == id);
            if (order == null)
            {
                return new EmptyResult();
            }
            return View(order);
        }

        [Route("JsonData")]
        public IActionResult GetJsonBook() 
        {
            Orders order = new Orders() 
            { 
                Id = 1,
                NameOfCompany = "Milka.Doo",
                NameOfProduct = "Milka Chocolate",
                Price = 35,
                OnAction = true
            }; 
            return new JsonResult(order); 
        }

        public IActionResult BackToPrivacy()
        {
            return RedirectToAction("Index", "Home"); // Home/Index          Dali ke moze podetalno da go objasnite redirect bidejki me buni...
        }
    }
}
