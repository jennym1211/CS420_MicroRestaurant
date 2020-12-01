using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRestaurantMVC.Controllers
{
    public class MicroBusBoyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
