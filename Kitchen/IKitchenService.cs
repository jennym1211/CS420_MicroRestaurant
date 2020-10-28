using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen
{
    public interface IKitchenService
    {
        Task CookFood(int OrderId);

        Task CompleteOrder(int orderId);

        Task WashDishes(int plateId);
    }
}