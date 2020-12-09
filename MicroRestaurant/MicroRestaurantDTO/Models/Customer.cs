using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurantMVC.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public bool HasPaid { get; set; }
        public bool IsOver21 { get; set; }
        public int CurrentSatisfaction { get; set; }
    }
}