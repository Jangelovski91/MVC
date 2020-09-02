using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    
    public class AccordinglyController : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            List<Order> Orders = new List<Order>()
            {
                new Order(){OrderNumber = 234, PizzaName = "Diavola"},
                new Order(){OrderNumber = 456, PizzaName = "Stellato"}
            };
            if (id != 0)
            {
                return View();
            }
            return new EmptyResult();
        }
        public IActionResult JsonOrder()
        {
            Order order123 = new Order
            {
                OrderNumber = 123,
                PizzaName = "Capricciosa"

            };
            return new JsonResult(order123);
        }
        public IActionResult BackToHomeIndex()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
