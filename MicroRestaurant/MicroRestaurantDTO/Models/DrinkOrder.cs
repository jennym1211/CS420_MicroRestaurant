using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MicroRestaurantMVC.Models
{
    public class DrinkOrder
    {
        public Drinks DrinkName { get; set; }

        [Key]
        public int OrderNumber { get; set; }

        public bool NonAlcoholic { get; set; }
    }

    public enum Drinks
    {
        Water,
        Soda,
        Beer,
        Wine
    }
}