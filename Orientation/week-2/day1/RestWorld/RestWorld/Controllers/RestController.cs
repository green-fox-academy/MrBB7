using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestWorld.Models;

namespace RestWorld.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting hiSayer = new Greeting()
            {
                Content = "Hello, " + name
            };
            return new JsonResult(hiSayer);
        }
    }
}