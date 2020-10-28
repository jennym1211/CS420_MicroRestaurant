using MicroRestaurantDTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hostess.Events.ConsumeEvents
{
    public class TableReadyEvent
    {
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public int TableId { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}