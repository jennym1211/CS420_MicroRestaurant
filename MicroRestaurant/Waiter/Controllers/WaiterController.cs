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

        public ActionResult CheckTable(int tableId)
        {
            throw new NotImplementedException();
        }

        public ActionResult PickUpOrder([FromBody] Order order, int orderId)
        {
            OrderReadyEvent ore = new OrderReadyEvent
            {
                Order = order,
                OrderId = orderId,
                TimeStamp = DateTime.Now
            };

            _eventBus.PublishEvent<OrderReadyEvent>("orderready", ore);

            return new JsonResult(ore);
        }

        [HttpPost]
        public ActionResult TakeOrder([FromBody] Order order, int orderId, IEnumerable<MenuItem> orderItems)
        {
            OrderTakenEvent ote = new OrderTakenEvent
            {
                Order = order,
                OrderItems = orderItems,
                OrderId = orderId,
                TimeStamp = DateTime.Now
            };

            _eventBus.PublishEvent<OrderTakenEvent>("ordertaken", ote);

            return new JsonResult(ote);
        }

        [HttpPost]
        public ActionResult TenderCheck(int customerId)
        {
            CheckPaidEvent cpe = new CheckPaidEvent();

            _eventBus.PublishEvent<CheckPaidEvent>("checktendered", cpe);

            return new JsonResult(cpe);
        }
    }
}