using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kitchen.Events.PublishEvents;
using Kitchen.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Kitchen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitchenController : ControllerBase
    {
        IConfiguration _configuration;
        IEventBus _eventBus;

        public KitchenController(IConfiguration configuration, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _configuration = configuration;
            eventBus.HostName = _configuration["rabbitmqhostname"];
            eventBus.PortNumber = Convert.ToInt32(_configuration["rabbitmqport"]);
        }

        public ActionResult CompleteOrder(int orderId)
        {
            OrderReadyEvent ore = new OrderReadyEvent();

            _eventBus.PublishEvent<OrderReadyEvent>("drinkready", ore);

            return new JsonResult(ore);
        }

        public ActionResult CookFood(int orderId)
        {
            throw new NotImplementedException();
        }

        public ActionResult WashDishes(int plateId)
        {
            throw new NotImplementedException();
        }
    }
}