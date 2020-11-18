using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hostess.Events.ConsumeEvents;
using Hostess.Events.PublishEvents;
using Hostess.Interfaces;
using MicroRestaurantDTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

public static class queues
{
    public const string seatedtable = "seatedtable";
}

namespace Hostess.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class HostessController : ControllerBase
    {
        IConfiguration _configuration;
        IEventBus _eventBus;

        public HostessController(IConfiguration configuration, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _configuration = configuration;
            eventBus.HostName = _configuration["rabbitmqhostname"];
            eventBus.PortNumber = Convert.ToInt32(_configuration["rabbitmqport"]);
        }

        [HttpGet]
        public ActionResult TableReady()
        {
            var tre = _eventBus.ConsumeEvent<TableReadyEvent>("tableready");

            return new JsonResult(tre);
        }

        [HttpGet]
        public ActionResult SeatedTable()
        {
            var ste = _eventBus.ConsumeEvent<SeatedTableEvent>("seatedtable");

            return new JsonResult(ste);
        }

        [HttpPost]
        public ActionResult SeatToTable([FromBody] SeatedTableEvent ste)
        {
            ste.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<SeatedTableEvent>(queues.seatedtable, ste);

            return new JsonResult(ste);
        }

        [HttpPost]
        public ActionResult TakeReservation([FromBody] ReservationTakenEvent rte)
        {
            rte.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<ReservationTakenEvent>("reservationtaken", rte);

            return new JsonResult(rte);
        }
    }
}