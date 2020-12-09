using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurantMVC.Models
{
    public class Plate
    {
        public List<MenuItem> OrderItems { get; set; } = new List<MenuItem>();
        public bool IsClean { get; set; }
        public bool CustomerFinished { get; set; }
    }
}