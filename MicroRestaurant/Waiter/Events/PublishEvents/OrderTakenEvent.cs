using MicroRestaurantDTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Waiter.Events.PublishEvents
{
    public class OrderTakenEvent
    {
        public Order Order { get; set; }

        public int OrderId { get; set; }

        public IEnumerable<MenuItem> OrderItems { get; set; }

        public DateTime TimeStamp { get; set; }

        public OrderTakenEvent(int orderId, IEnumerable<MenuItem> orderItems)
        {
            OrderId = orderId;

            OrderItems = orderItems;
        }
    }
}