using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Waiter.Events.ConsumeEvents;
using Waiter.Events.PublishEvents;
using Waiter.Interfaces;

namespace Waiter.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WaiterController : ControllerBase
    {
        IConfiguration _configuration;
        IEventBus _eventBus;

        public WaiterController(IConfiguration configuration, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _configuration = configuration;
            eventBus.HostName = _configuration["rabbitmqhostname"];
            eventBus.PortNumber = Convert.ToInt32(_configuration["rabbitmqport"]);
        }

        //public ActionResult CheckTable(int tableId)
        //{
        //    throw new NotImplementedException();
        //}

        [HttpPost]
        public ActionResult TakeFoodOrder([FromBody] FoodOrderTakenEvent ote)
        {
            //OrderItems = orderItems,
            //OrderId = orderId,
            ote.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<FoodOrderTakenEvent>("foodordertaken", ote);

            return new JsonResult(ote);
        }

        [HttpPost]
        public ActionResult TenderCheck([FromBody] CheckPaidEvent cpe)
        {
            cpe.TimeStamp = new DateTime();

            _eventBus.PublishEvent<CheckPaidEvent>("checkPaid", cpe);

            return new JsonResult(cpe);
        }

        [HttpPost]
        public ActionResult TakeDrinkOrder([FromBody] DrinkOrderTakenEvent dte)
        {
            //OrderItems = orderItems,
            //OrderId = orderId,
            dte.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent("drinkordertaken", dte);

            return new JsonResult(dte);
        }

        [HttpGet]
        public ActionResult ReadyToPay()
        {
            var cpe = _eventBus.ConsumeEvent("ReadyToPayEvent");

            return new JsonResult(cpe);
        }

        [HttpGet]
        public ActionResult DrinkReady()
        {
            return new JsonResult(_eventBus.ConsumeEvent("DrinkOrderReadyEvent"));
        }

        [HttpGet]
        public ActionResult FoodReady()
        {
            return new JsonResult(_eventBus.ConsumeEvent("FoodOrderReadyEvent"));
        }
    }
}