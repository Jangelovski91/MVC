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
    public class OrderController : Controller
    {

        public IActionResult Index()
        {
            List<Order> orders = StaticDB.OrderList;
            List<OrderDetailsViewModel> OrderDetailsViewModels = new List<OrderDetailsViewModel>();
            foreach (Order order in orders)
            {
                OrderDetailsViewModels.Add(OrderMapper.OrderToViewModel(order));
            }
            return View(OrderDetailsViewModels);
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
        
        public IActionResult BackToHomeIndex()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
