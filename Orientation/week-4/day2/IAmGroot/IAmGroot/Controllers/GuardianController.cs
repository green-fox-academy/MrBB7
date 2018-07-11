using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IAmGroot.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet("/groot")]
        public IActionResult Index(string message)
        {
            if (message == null)
            {
                return new JsonResult(new
                {
                    error = "I am Groot!"
                });
            }
            else
            {
                return new JsonResult(new
                {
                    received = message,
                    translated = "I am Groot!"
                });
            }
        }
    }
}