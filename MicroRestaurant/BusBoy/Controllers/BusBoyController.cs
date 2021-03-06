﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusBoy.Events.ConsumeEvents;
using BusBoy.Events.PublishEvents;
using BusBoy.Interfaces;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BusBoy.Controllers
{
    [Route("api/[controller]/[action]")]
    //[ApiController]
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

        [HttpPost]
        public ActionResult CleanTable([FromBody] TableReadyEvent tre)
        {
            tre.TimeStamp = DateTime.Now;
            //TablesInUse.Add(table);

            _eventBus.PublishEvent("TableReady", tre);

            return new JsonResult(tre);
        }

        [HttpGet]
        public ActionResult GetCheckPaid()
        {
            return new JsonResult(_eventBus.ConsumeEvent("GetCheckPaid"));
        }
    }
}