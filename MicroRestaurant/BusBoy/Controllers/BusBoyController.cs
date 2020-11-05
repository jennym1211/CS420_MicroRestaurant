using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusBoy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusBoyController : ControllerBase
    {
        public ActionResult GatherPlates(int tableId)
        {
            throw new NotImplementedException();
        }

        public ActionResult CleanTable(int tableId)
        {
            throw new NotImplementedException();
        }
    }
}