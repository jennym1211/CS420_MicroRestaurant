using System;
using System.Collections.Generic;
using System.Text;

namespace Hostess.Events.PublishEvents
{
    public class ReservationFilledEvent
    {
        public int GuestCount { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}