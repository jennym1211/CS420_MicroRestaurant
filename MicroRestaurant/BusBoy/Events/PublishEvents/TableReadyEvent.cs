using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusBoy.Events.PublishEvents
{
    public class TableReadyEvent
    {
        public int TableNumber { get; set; }
        public int SeatCount { get; set; }
        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            return "TableNumber;SeatCount;TimeStamp";
        }
    }
}