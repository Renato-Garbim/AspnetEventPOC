using EventPOC.CustomEventsArgs;
using EventPOC.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPOC.Service
{
    public class FoodOrderService
    {
        public event EventHandler<FoodPreparedEventArgs> FoodPrepared;

        public void PrepareOrder(Order order)
        {
            Console.WriteLine($"Preparing your order '{order.Item}', please wait...");
            Thread.Sleep(4000);

            OnFoodPrepared(order);

        }

        protected virtual void OnFoodPrepared(Order order)
        {
            FoodPrepared?.Invoke(this, new FoodPreparedEventArgs { Order = order });
        }
    }
}
