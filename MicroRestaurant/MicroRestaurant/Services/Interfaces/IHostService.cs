using MicroRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Services.Interfaces
{
    public interface IHostService
    {
        Task SeatToTable(Customer customer);

        Task TakeReservation(Customer customer);
    }
}