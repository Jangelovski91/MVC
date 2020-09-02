using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult JsonData()
        {
            Pizza pizza = new Pizza
            {
                ID = 1,
                Name = "QuatroFormaggi"

            };
            return new JsonResult(pizza);
        }
        public IActionResult BackToHome()
        {
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Details(int? id)
        {
            if(id != null)
            {
                return View();
            }
            return new EmptyResult();
        }
    }
}
