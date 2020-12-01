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
        public int TableId { get; set; }

        public int ReservationId { get; set; }

        public DateTime TimeStamp { get; set; }

        //public TableReadyEvent(List<int> TablesInUse, List<int> CurrentReservations)
        //{
        //    TablesInUse.Add(TableId);
        //    CurrentReservations.Remove(ReservationId);
        //}
    }
}