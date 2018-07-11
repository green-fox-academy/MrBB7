using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestWorld.Models;

namespace RestWorld.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting()
            {
                Id = 1,
                Content = "hello " + name
            };

            return View(greeting);
        }

        [Route("allhello")]
        public IActionResult AllHello(string name)
        {
            EveryHello allTheHellos = new EveryHello()
            {
                Name = name
            };
            return View(allTheHellos);
        }
    }

}
