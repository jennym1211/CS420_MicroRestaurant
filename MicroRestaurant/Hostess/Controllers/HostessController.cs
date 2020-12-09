using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hostess.Events.ConsumeEvents;
using Hostess.Events.PublishEvents;
using Hostess.Interfaces;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

public static class Queues
{
    public const string seatedtable = "seatedtable";
    public const string reservationfilled = "reservationfilled";
}

namespace Hostess.Controllers
{
    [Route("api/[controller]/[action]")]
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
            return new JsonResult(_eventBus.ConsumeEvent(Queues.seatedtable));
        }

        [HttpGet]
        public ActionResult GetReservation()
        {
            return new JsonResult(_eventBus.ConsumeEvent(Queues.reservationfilled));
        }

        [HttpPost]
        public ActionResult SeatToTable([FromBody] SeatedTableEvent ste)
        {
            ste.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<SeatedTableEvent>(Queues.seatedtable, ste);

            return new JsonResult(ste);
        }

        [HttpPost]
        public ActionResult TakeReservation([FromBody] ReservationFilledEvent rfe)
        {
            rfe.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<ReservationFilledEvent>(Queues.reservationfilled, rfe);

            return new JsonResult(rfe);
        }
    }
}