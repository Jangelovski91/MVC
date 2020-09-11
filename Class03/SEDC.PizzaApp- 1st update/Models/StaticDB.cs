using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models
{
    public class StaticDB
    {
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza(){ID = 1, Name = "Capricciosa", Price = 250, PizzaSize = PizzaSize.Normal, HasExtras = false},
            new Pizza(){ID = 2, Name = "Quatro Formaggi", Price = 350, PizzaSize = PizzaSize.Family, HasExtras = true},
            new Pizza(){ID = 3, Name = "Stelatto", Price = 300, PizzaSize = PizzaSize.Family, HasExtras = true}

        };
        public static List<Order> OrderList = new List<Order>()
        {
            new Order()
            {
                ID = 1,
                Pizza = Pizzas[0],

                User = new User
                {
                    ID = 1,
                    FirstName = "Aleksandar",
                    LastName = "Jangelovski",
                    Address = "Address1"
                }

            },
            new Order()
            {
                ID = 2,
                Pizza = Pizzas[2],

                User = new User
                {
                    ID = 1,
                    FirstName = "Bob",
                    LastName = "Bobski",
                    Address = "Address2"
                }

            }
        };
    }
}
