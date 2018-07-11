using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MacrotisExam.Services;
using Microsoft.AspNetCore.Mvc;

namespace MacrotisExam.Controllers
{
    [Route("")]
    public class AttractionController : Controller
    {

        private IService attractionDatabase;

        public AttractionController(IService attractionDatabase)
        {
            this.attractionDatabase = attractionDatabase;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}