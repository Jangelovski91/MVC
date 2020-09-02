using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models
{
    public class StaticDB
    {
        public static List<Order> OrderList = new List<Order>()
            {
                new Order(){OrderNumber = 234, PizzaName = "Diavola"},
                new Order(){OrderNumber = 456, PizzaName = "Stellato"}
            };
    }
}
