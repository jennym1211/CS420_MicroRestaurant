using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Models
{
    public class Table : EntityBase
    {
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public int TableNumber { get; set; }

        public bool IsAvailable { get; set; }
        public bool IsClean { get; set; }

        public int NumOfCustomers { get; set; }
    }
}