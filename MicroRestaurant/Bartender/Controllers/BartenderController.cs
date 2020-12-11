using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bartender.Events.ConsumeEvents;
using Bartender.Events.PublishEvents;
using Bartender.Interfaces;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Bartender.Controllers
{
    [Route("api/[controller]/[action]")]
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

        [HttpPost]
        public ActionResult DrinkReady([FromBody] DrinkReadyEvent dre)
        {
            dre.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent("DrinkOrderReady", dre);

            return new JsonResult(dre);
        }

        [HttpGet]
        public ActionResult GetDrinkOrder()//
        {
            return new JsonResult(_eventBus.ConsumeEvent("DrinkOrderTaken"));
        }
    }
}