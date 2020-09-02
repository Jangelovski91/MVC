using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Details(int? id)
        {
            var orders = StaticDB.OrderList;
            if (id != 0)
            {
                return View(orders);
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
