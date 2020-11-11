using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusBoy.Events.PublishEvents;
using BusBoy.Interfaces;
using MicroRestaurantDTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BusBoy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusBoyController : ControllerBase
    {
        IConfiguration _configuration;
        IEventBus _eventBus;

        public BusBoyController(IConfiguration configuration, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _configuration = configuration;
            eventBus.HostName = _configuration["rabbitmqhostname"];
            eventBus.PortNumber = Convert.ToInt32(_configuration["rabbitmqport"]);
        }

        public ActionResult GatherPlates(int tableId)
        {
            throw new NotImplementedException();
        }

        public ActionResult CleanTable([FromBody] Table table, int tableId, List<Table> TablesInUse)
        {
            TableReadyEvent tre = new TableReadyEvent
            {
                Table = table,
                TableId = tableId
            };
            TablesInUse.Add(table);

            _eventBus.PublishEvent<TableReadyEvent>("drinkready", tre);

            return new JsonResult(tre);
        }
    }
}