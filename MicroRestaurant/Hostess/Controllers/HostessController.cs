using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hostess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostessController : ControllerBase
    {
        public Task SeatToTable(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public Task TakeReservation(int CustomerId)
        {
            throw new NotImplementedException();
        }
    }
}