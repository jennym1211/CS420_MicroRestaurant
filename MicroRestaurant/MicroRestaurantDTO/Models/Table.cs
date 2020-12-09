using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurantMVC.Models
{
    public class Table
    {
        public int TableNumber { get; set; }

        public bool IsAvailable { get; set; }
        public bool IsClean { get; set; }

        public int NumOfCustomers { get; set; }
    }
}