using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MicroRestaurantDTO.Models
{
    public class Reservation : EntityBase
    {
        public int TableId { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }

        public int NumOfCustomers { get; set; }
    }
}