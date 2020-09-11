using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "List of pizzas";

            List<Pizza> pizzas = StaticDB.Pizzas;
            List<PizzaViewModel> PizzaViewModels = new List<PizzaViewModel>();

            foreach (Pizza pizza in pizzas)
            {
                PizzaViewModels.Add(PizzaMapper.PizzaToViewModel(pizza));
            };
            return View(PizzaViewModels);
        }
        
        public IActionResult BackToHome()
        {
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Details(int? id)
        {
            ViewData["Title"] = "Pizza Details:";
            ViewBag.Pizza = StaticDB.Pizzas.First(p => p.ID == id);
            if (id == null)
            {
                return new EmptyResult();
            }
            return View();
        }
    }
}
