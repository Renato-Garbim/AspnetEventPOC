using EventPOC.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPOC.CustomEventsArgs
{
    public class FoodPreparedEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }
}
