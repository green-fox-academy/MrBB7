using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWorld.Controllers
{
    public class HomeController : Controller
    {
        [Route("[controller]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Hello")]
        public IActionResult Hello()
        {
            return Content("Hello World");
        }
    }
}