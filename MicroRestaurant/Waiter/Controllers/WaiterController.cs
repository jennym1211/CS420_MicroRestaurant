using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Waiter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaiterController : ControllerBase
    {
        public WaiterController()
        {
        }

        public ActionResult CheckTable(int tableId)
        {
            throw new NotImplementedException();
        }

        public ActionResult PickUpOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public ActionResult TakeOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public ActionResult TenderCheck(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}