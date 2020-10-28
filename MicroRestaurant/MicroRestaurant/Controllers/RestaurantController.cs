using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRestaurant.Interfaces;
using MicroRestaurant.Models;
using MicroRestaurant.Models.Events;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroRestaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private IConfiguration _configuration;
        private IEventBus _eventBus;

        public RestaurantController(IConfiguration configuration, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _configuration = configuration;
            eventBus.HostName = _configuration["rabbitmqhostname"];
            eventBus.PortNumber = Convert.ToInt32(_configuration["rabbitmqport"]);
        }

        [HttpPost]
        public ActionResult TableReady([FromBody] Table table, int CustomerId, int WaiterId)
        {
            TableReadyEvent tre = new TableReadyEvent();

            tre.Table = table;
            tre.CustomerId = CustomerId;
            tre.WaiterId = WaiterId;

            _eventBus.PublishEvent<TableReadyEvent>("tableready", tre);

            return new JsonResult(tre);
        }
    }
}