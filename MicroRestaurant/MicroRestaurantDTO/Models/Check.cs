using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRestaurantMVC.Models
{
    class Check
    {
        public int OrderNumber { get; set; }

        public double CheckTotal { get; set; }

        public bool CheckPaid { get; set; }
    }
}