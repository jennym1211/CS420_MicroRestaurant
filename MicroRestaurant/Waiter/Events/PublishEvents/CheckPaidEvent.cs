using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waiter.Events.PublishEvents
{
    public class CheckPaidEvent
    {
        public int TableNumber { get; set; }
        public bool Paid { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}