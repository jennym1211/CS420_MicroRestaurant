using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Waiter.Events.ConsumeEvents
{
    public class FoodOrderReadyEvent
    {
        public int OrderNumber { get; set; }
        public string Name { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}