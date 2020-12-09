using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waiter.Events.ConsumeEvents
{
    public class TableSeatedEvent
    {
        public int TableNumber { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}