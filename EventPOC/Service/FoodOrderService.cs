using EventPOC.CustomEventsArgs;
using EventPOC.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EventPOC.Delegates.DelegatesOrder;

namespace EventPOC.Service
{
    public class FoodOrderService
    {
        public event EventHandler<FoodPreparedEventArgs> FoodPrepared;
        public event OrderCanBeGerated OrderCanBeGerated;
        public event OrderCanBeGeratedFrom<FoodPreparedEventArgs> OrderCanBeGeneratedFrom;
        

        public void PrepareOrder(Order order)
        {
            Console.WriteLine($"Preparing your order '{order.Item}', please wait...");
            Thread.Sleep(4000);


            OnOrderCanBeGerated(order);
            OnFoodPrepared(order);

        }

        public virtual bool? OnOrderCanBeGeneratedFrom(Order order)
        {
            return OrderCanBeGeneratedFrom?.Invoke(new FoodPreparedEventArgs { Order = order });
        }

        protected virtual void OnOrderCanBeGerated(Order order)
        {
            OrderCanBeGerated?.Invoke(new FoodPreparedEventArgs { Order = order });
        }

        protected virtual void OnFoodPrepared(Order order)
        {
            FoodPrepared?.Invoke(this, new FoodPreparedEventArgs { Order = order });
        }
    }
}
