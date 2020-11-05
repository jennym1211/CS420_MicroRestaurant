using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitchenController : ControllerBase
    {
        public ActionResult CompleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public ActionResult CookFood(int orderId)
        {
            throw new NotImplementedException();
        }

        public ActionResult WashDishes(int plateId)
        {
            throw new NotImplementedException();
        }
    }
}