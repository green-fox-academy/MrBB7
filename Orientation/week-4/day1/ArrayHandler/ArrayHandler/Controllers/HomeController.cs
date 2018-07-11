using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ArrayHandler.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost("/arrays")]
        public IActionResult Index()
        {
            return View();
        }
    }
}