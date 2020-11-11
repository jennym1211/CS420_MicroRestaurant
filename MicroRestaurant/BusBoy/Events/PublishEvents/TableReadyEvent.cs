using MicroRestaurantDTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusBoy.Events.PublishEvents
{
    public class TableReadyEvent
    {
        public Table Table { get; set; }
        public int TableId { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}