﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waiter.Events.ConsumeEvents
{
    public class ReadyToPayEvent
    {
        public int OrderNumber { get; set; }

        public int TableNumber { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}