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
    //[ApiController]
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

        [HttpGet]
        public ActionResult GetOrder()
        {
            var ote = _eventBus.ConsumeEvent<OrderTakenEvent>("ordertaken");

            return new JsonResult(ote);
        }

        [HttpPost]
        public ActionResult TakeOrder([FromBody] OrderTakenEvent ote)
        {
            //DrinkReadyEvent dre = new DrinkReadyEvent
            //{
            //};
            _eventBus.PublishEvent("drinkready", ote);

            //return new JsonResult(dre);
            return new JsonResult(ote);
        }

        [HttpPost]
        public ActionResult DrinkReady([FromBody] DrinkReadyEvent drinkReady)
        {
            drinkReady.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent("drinkReady", drinkReady);

            return new JsonResult(drinkReady);
        }

        [HttpGet]
        public ActionResult GetDrinkOrder()
        {
            return new JsonResult(_eventBus.ConsumeEvent<DrinkReadyEvent>("drinkOrder"));
        }
    }
}