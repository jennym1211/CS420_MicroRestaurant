using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurant.Services.Interfaces
{
    public interface IBusBoyService
    {
        Task CleanTable(int tableId);

        public Task GatherPlates(int tableId);
    }
}