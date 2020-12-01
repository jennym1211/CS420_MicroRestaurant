using MicroRestaurantDTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Events.PublishEvents
{
    public class DrinkReadyEvent
    {
        public int TableNumber { get; set; }

        public int OrderNumber { get; set; }

        public String DrinkName { get; set; }

        public bool Alcoholic { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}