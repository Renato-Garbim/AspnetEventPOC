using EventPOC.CustomEventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPOC.Service
{
    public class MailService
    {
        public void OnFoodPrepared(object source, FoodPreparedEventArgs eventArgs)
        {
            Console.WriteLine($"AppService: your food '{eventArgs.Order.Item}' is prepared. ");
        }
    }
}
