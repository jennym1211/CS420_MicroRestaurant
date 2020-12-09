using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurantMVC.Models
{
    public class Restaurant
    {
        public List<Table> Tables { get; set; } = new List<Table>();
        public List<Table> CurrentBarStools { get; set; } = new List<Table>();
        public List<FoodOrder> Orders { get; set; } = new List<FoodOrder>();
        public int NumberofReservations { get; set; }
        public List<Plate> DirtyPlates { get; set; } = new List<Plate>();
    }
}