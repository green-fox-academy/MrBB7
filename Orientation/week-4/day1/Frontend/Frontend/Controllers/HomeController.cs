using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
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

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return new JsonResult(new
            {
                appendedContent = appendable + "a"
            });
        }

        [HttpGet("/appenda")]
        public IActionResult AppendA()
        {
            return StatusCode(404);
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody]DoUntil doUntil)
        {
            if (doUntil.Until == null)
            {
                return new JsonResult(new
                {
                    error = "Please provide a number!"
                });
            }
            else
            {
                if (what == "sum")
                {
                    return new JsonResult(new
                    {
                        result = doUntil.Sum()
                    });
                }
                else if (what == "factor")
                {
                    return new JsonResult(new
                    {
                        result = doUntil.Factorial()
                    });
                }
            }
            return new JsonResult(new
            {
                error = "Please provide a number!"
            });
        }
    }
}
