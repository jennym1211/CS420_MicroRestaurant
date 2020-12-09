using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Events.ConsumeEvents
{
    public class OrderTakenEvent
    {
        public int TableNumber { get; set; }

        public int OrderNumber { get; set; }

        public int DrinkName { get; set; }

        public bool Alcoholic { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}