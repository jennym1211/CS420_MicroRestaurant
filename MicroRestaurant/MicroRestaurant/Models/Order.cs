using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Models
{
    public class Order : EntityBase
    {
        public int TableId { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }

        public decimal? OrderTotal { get; set; }

        public string OrderStatus { get; set; }

        // [InverseProperty("Order")]
        public List<Plate> Plates { get; set; } = new List<Plate>();
    }
}