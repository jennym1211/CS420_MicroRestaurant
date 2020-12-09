using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurantMVC.Models
{
    public class FoodOrder
    {
        [Key]
        public int OrderNumber { get; set; }

        public Food FoodName { get; set; }

        public DateTime TimeStamp { get; set; }
    }

    public enum Food
    {
        CheeseOmelette,
        MediumSteak,
        BLTSandwich,
        MacAndCheese,
        Burrito,
        Salad
    }
}