using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waiter
{
    public interface IWaiterService
    {
        Task TakeOrder(int orderId);

        Task PickUpOrder(int orderId);

        Task CheckTable(int tableId);

        Task TenderCheck(int customerId);
    }
}