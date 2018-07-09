using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling([FromQuery]int? input)
        {
            if (input == null)
            {
                return new JsonResult(new
                {
                    error = "Please provide an input "
                });
            }
            else
            {
                return new JsonResult(new
                {
                    received = input,
                    result = input * 2
                });
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter([FromQuery] string name)
        {
            if (name == null)
            {
                return new JsonResult(new
                {
                    error = "Please provide a name!"
                });
            }
            else
            {
                return new JsonResult(new
                {
                    welcome_message = $"Oh, hi there {name}, my dear student!"
                });
            }
        }
    }
}