using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeOne.Controllers
{
    [Route("/")]
    public class GreetController : Controller
    {
        private IGreet greeting;

        public GreetController(IGreet greeting)
        {
            this.greeting = greeting;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult GetName(string name)
        {
            greeting.SetName(name);
            return RedirectToAction("greet");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet()
        {
            return View("greet", greeting.GetName());
        }

    }
}