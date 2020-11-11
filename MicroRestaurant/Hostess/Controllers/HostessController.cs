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

namespace Hostess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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

        [HttpPost]
        public ActionResult SeatToTable([FromBody] Table table, int tableID)
        {
            SeatedTableEvent ste = new SeatedTableEvent();
            ste.Table = table;
            ste.Table.Id = tableID;
            ste.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<SeatedTableEvent>("seatedtable", ste);

            return new JsonResult(ste);
        }

        [HttpPost]
        public ActionResult TakeReservation([FromBody] Table table, int TableId)
        {
            ReservationTakenEvent rte = new ReservationTakenEvent();
            rte.Table = table;
            rte.TableId = TableId;
            rte.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<ReservationTakenEvent>("reservationtaken", rte);

            return new JsonResult(rte);
        }
    }
}