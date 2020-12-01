using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusBoy.Events.ConsumeEvents
{
    public class CheckPaidEvent
    {
        public int TableNumber { get; set; }
        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            return "TableNumber;TimeStamp";
        }
    }
}