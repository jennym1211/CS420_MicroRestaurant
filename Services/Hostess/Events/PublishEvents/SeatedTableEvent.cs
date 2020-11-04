using MicroRestaurantDTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hostess.Events.PublishEvents
{
    public class SeatedTableEvent
    {
        public Table Table { get; set; }

        public int TableId { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}