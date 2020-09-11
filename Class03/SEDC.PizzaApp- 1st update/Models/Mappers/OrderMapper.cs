using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class OrderMapper
    {
        public static OrderDetailsViewModel OrderToViewModel(Order order)
        {
            return new OrderDetailsViewModel()
            {
                Id = order.ID,
                PizzaName = order.Pizza.Name,
                Price = order.Pizza.Price,
                FullName = $"{ order.User.FirstName}  { order.User.LastName}"
            };
        }
    }
}
