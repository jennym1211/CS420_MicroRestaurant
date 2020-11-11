using MicroRestaurantDTO.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Events.ConsumeEvents
{
    public class OrderTakenEvent
    {
        public Order Order { get; set; }

        public int OrderId { get; set; }

        public IEnumerable<MenuItem> OrderItems { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}