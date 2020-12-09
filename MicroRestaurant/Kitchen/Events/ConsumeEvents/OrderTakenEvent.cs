using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Events.ConsumeEvents
{
    public class OrderTakenEvent
    {
        public int OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public string Food { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}