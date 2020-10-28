using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Models
{
    public class Plate : EntityBase
    {
        public List<MenuItem> OrderItems { get; set; } = new List<MenuItem>();
        public bool IsClean { get; set; }

        public bool CustomerFinished { get; set; }
    }
}