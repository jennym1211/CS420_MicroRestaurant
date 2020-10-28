using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Services.Interfaces
{
    public interface IKitchenService
    {
        Task CookFood(int OrderId);

        Task CompleteOrder(int orderId);

        Task WashDishes(int plateId);
    }
}