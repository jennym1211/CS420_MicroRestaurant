using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Waiter.Events.PublishEvents
{
    public class FoodOrderTakenEvent
    {
        public int OrderNumber { get; set; }
        public String Name { get; set; }

        public int TableNumber { get; set; }
        //public IEnumerable<MenuItem> OrderItems { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}