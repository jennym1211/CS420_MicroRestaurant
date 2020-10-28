using Kitchen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Services
{
    public class KitchenService : IKitchenService
    {
        public Task CompleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task CookFood(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task WashDishes(int plateId)
        {
            throw new NotImplementedException();
        }
    }
}