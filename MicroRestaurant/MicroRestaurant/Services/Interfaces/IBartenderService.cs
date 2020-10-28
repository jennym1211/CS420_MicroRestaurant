using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Services.Interfaces
{
    public interface IBartenderService
    {
        Task PourDrink(int orderId);
    }
}