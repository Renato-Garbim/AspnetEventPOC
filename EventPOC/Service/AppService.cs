using EventPOC.CustomEventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPOC.Service
{
    public class AppService
    {
        public void OnFoodRepared(object source, FoodPreparedEventArgs eventArgs)
        {
            Console.WriteLine($"AppService: your food '{eventArgs.Order.Item}' is prepared. ");
        }

        public void OnOrderCanBeGerated(FoodPreparedEventArgs eventArgs)
        {
            string description = eventArgs.Order.Item;

            if (string.IsNullOrEmpty(description))
            {
                Console.WriteLine($"AppService: your Order doesnt have any Item description. ");
            }

            Console.WriteLine($"AppService: Oder ready to go to the kitchen.");

        }
    }
}
