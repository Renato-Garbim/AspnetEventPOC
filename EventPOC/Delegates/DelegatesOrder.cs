using EventPOC.CustomEventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPOC.Delegates
{
    public class DelegatesOrder
    {
        public delegate void OrderCanBeGerated(FoodPreparedEventArgs args);
        public delegate bool OrderCanBeGeratedFrom<TEntityEventArgs>(TEntityEventArgs data) where TEntityEventArgs : EventArgs;
    }
}
