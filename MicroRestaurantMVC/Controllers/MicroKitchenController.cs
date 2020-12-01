using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurantMVC.Controllers
{
    public class MicroKitchenController : Controller
    {
        readonly string uri = "http://localhost:2236/api/kitchen";

        // GET: MicroKitchenController
        public ActionResult Index()
        {
            return View();
        }
    }
}