using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace MicroRestaurant.Models.Staff
{
    public class Waiter : EntityBase
    {
        public string OrderGet { get; set; }

        public string CheckTable { get; set; }

        public int CheckAmount { get; set; }
    }
}