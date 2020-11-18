using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRestaurantDTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Waiter.Events.ConsumeEvents;
using Waiter.Events.PublishEvents;
using Waiter.Interfaces;

namespace Waiter.Controllers
{
    [Route("api/[controller]")]
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

        [HttpGet("{id}")]
        public ActionResult ReadyToPay(int id)
        {
            var cpe = _eventBus.ConsumeEvent<CheckPaidEvent>("checkpaid");

            return new JsonResult(cpe);
        }

        [HttpGet("{id}")]
        public ActionResult PickUpFoodOrder(int id)
        {
            var ore = _eventBus.ConsumeEvent<OrderReadyEvent>("orderready");

            return new JsonResult(ore);
        }

        [HttpGet("{id}")]
        public ActionResult PickUpDrinkOrder(int id)
        {
            var dre = _eventBus.ConsumeEvent<DrinkReadyEvent>("drinkready");

            return new JsonResult(dre);
        }

        [HttpPost]
        public ActionResult TakeOrder([FromBody] OrderTakenEvent ote)
        {
            //OrderItems = orderItems,
            //OrderId = orderId,
            ote.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent("ordertaken", ote);

            return new JsonResult(ote);
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult TenderCheck([FromBody] CheckPaidEvent cpe)
        {
            _eventBus.PublishEvent("checktendered", cpe);

            return new JsonResult(cpe);
            throw new NotImplementedException();
        }
    }
}