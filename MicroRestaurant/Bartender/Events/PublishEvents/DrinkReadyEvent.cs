using MicroRestaurantDTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Events.PublishEvents
{
    public class DrinkReadyEvent
    {
        public Order Order { get; set; }
    }
}