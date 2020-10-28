using MicroRestaurant.Models.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Models.Events
{
    public class TableReadyEvent
    {
        public int WaiterId { get; set; }

        [ForeignKey("HostId")]
        public Host Host { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public int TableId { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}