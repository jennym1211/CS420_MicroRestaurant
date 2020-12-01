using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waiter.Events.ConsumeEvents
{
    public class DrinkOrderReadyEvent
    {
        public int OrderNumber { get; set; }
        public String Name { get; set; }
        public bool Alcoholic { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}