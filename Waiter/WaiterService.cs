using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Waiter
{
    public class WaiterService : IWaiterService
    {
        private HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;

        public WaiterService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            // _remoteServiceBaseUrl =
        }

        public Task CheckTable(int tableId)
        {
            throw new NotImplementedException();
        }

        public Task PickUpOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task TakeOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task TenderCheck(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}