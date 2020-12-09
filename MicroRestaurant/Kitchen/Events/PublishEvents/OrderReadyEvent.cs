using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Events.PublishEvents
{
    public class OrderReadyEvent
    {
        public int OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public string FoodName { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}