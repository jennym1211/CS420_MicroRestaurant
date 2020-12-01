using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRestaurantMVC.Controllers
{
    public class MicroHostessController : Controller
    {
        readonly string baseUri = "http://localhost:53874/api/hostess";

        public IActionResult Index()
        {
            return View();
        }
    }
}