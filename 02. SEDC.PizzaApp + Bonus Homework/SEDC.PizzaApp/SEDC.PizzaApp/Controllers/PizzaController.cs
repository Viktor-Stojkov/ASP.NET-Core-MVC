using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzasIndex = StaticDB.Pizzas;
            List<PizzaViewModel> pizzaViewModels = pizzasIndex.Select(x => PizzaOrderMappers.pizzaViewModel(x)).ToList();
            //return View(pizzasDB); // we send the list to the view
            ViewData["Title"] = "Pizzas";  // We can change on every browser our title
            ViewData["Data"] = DateTime.Now.ToShortDateString(); // Зашто во Index не ми го печати времето ?
            return View (pizzaViewModels);
        }

        public IActionResult Details(int? id)
        {
            List<Pizza> pizzasDetails = StaticDB.Pizzas;
            if (id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDB.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }
            PizzaViewModel pizzaViewModel = PizzaOrderMappers.pizzaViewModel(pizza);
            ViewBag.PizzaViewModel = pizzaViewModel;  // Пристап од ViewBag до PizzaVIewModel пропертињата.
            ViewData["Title"] = "Details"; // We can change on every browser our title
            ViewData["Date"] = DateTime.Now.ToShortDateString();  
            return View(pizza);
        }

        [Route("SeePizzas")]  // localhost:[port]/SeePizzas
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
