using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender
{
    public interface IBartenderService
    {
        Task PourDrink(int orderId);
    }
}