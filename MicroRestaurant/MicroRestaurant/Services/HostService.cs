using MicroRestaurant.Models;
using MicroRestaurant.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Services
{
    public class HostService : IHostService
    {
        public Task SeatToTable(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task TakeReservation(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}