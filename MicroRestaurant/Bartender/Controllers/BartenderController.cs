using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bartender.Events.ConsumeEvents;
using Bartender.Events.PublishEvents;
using Bartender.Interfaces;
using MicroRestaurantDTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Bartender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BartenderController : ControllerBase
    {
        IConfiguration _configuration;
        IEventBus _eventBus;

        public BartenderController(IConfiguration configuration, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _configuration = configuration;
            eventBus.HostName = _configuration["rabbitmqhostname"];
            eventBus.PortNumber = Convert.ToInt32(_configuration["rabbitmqport"]);
        }

        public ActionResult PourDrink(int orderId)
        {
            DrinkReadyEvent dre = new DrinkReadyEvent
            {
            };
            _eventBus.PublishEvent<DrinkReadyEvent>("drinkready", dre);

            return new JsonResult(dre);
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
    }
}