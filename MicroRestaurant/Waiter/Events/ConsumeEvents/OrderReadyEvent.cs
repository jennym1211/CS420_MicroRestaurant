using MicroRestaurantDTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Waiter.Events.ConsumeEvents
{
    public class OrderReadyEvent
    {
        public Order Order { get; set; }

        public Table Table { get; set; }

        public int OrderId { get; set; }
        public int TableId { get; set; }

        public DateTime TimeStamp { get; set; }

        public OrderReadyEvent(int orderId, int tableId)
        {
            OrderId = orderId;
            TableId = tableId;
        }
    }
}