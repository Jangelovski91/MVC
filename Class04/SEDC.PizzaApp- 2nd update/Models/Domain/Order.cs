using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models
{
    public class Order
    {
        public int ID { get; set; }
        public Pizza Pizza { get; set; }
        public User User { get; set; }

    }
}
