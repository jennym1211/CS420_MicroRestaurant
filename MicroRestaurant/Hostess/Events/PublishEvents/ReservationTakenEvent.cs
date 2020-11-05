using MicroRestaurantDTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hostess.Events.ConsumeEvents
{
    public class ReservationTakenEvent
    {
        public Table Table { get; set; }

        public int TableId { get; set; }

        public int NumOfCustomers { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}