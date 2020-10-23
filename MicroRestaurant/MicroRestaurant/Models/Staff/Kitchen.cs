using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Models.Staff
{
    public class Kitchen : EntityBase
    {
        public int MealsCooked { get; set; }
        public int DishesWashed { get; set; }
    }
}