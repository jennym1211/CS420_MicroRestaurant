using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MicroRestaurantMVC.Models
{
    public class Reservation
    {
        public int TableId { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }

        public int NumOfCustomers { get; set; }
    }
}