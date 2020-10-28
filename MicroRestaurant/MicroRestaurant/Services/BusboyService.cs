using MicroRestaurant.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Services
{
    public class BusboyService : IBusBoyService
    {
        public Task GatherPlates(int tableId)
        {
            throw new NotImplementedException();
        }

        public Task CleanTable(int tableId)
        {
            throw new NotImplementedException();
        }
    }
}