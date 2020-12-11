using System;
using System.Collections.Generic;
using System.Text;

namespace Hostess.Events.PublishEvents
{
    public class SeatedTableEvent
    {
        public int GuestCount { get; set; }
        public int TableNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}