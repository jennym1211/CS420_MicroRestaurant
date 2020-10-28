using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurantDTO.Models
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public bool HasPaid { get; set; }
        public bool IsOver21 { get; set; }
        public int CurrentSatisfaction { get; set; }
    }
}