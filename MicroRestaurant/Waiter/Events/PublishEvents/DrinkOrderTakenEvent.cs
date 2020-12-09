using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waiter.Events.PublishEvents
{
    public class DrinkOrderTakenEvent
    {
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public bool Alcoholic { get; set; }
        public int TableNumber { get; set; }

        public DateTime TimeStamp
        {
            get; set;
        }
    }
}