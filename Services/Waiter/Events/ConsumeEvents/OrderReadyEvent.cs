using MicroRestaurantDTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Waiter.Events.ConsumeEvents
{
    public class OrderReady
    {
        public Order Order { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}