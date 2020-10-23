using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace MicroRestaurant.Models.Staff
{
    public class Host : EntityBase
    {
        public int NumberOfTables { get; set; }
        public int NumberofReservations { get; set; }
        public int TablesAvailable { get; set; }
    }
}