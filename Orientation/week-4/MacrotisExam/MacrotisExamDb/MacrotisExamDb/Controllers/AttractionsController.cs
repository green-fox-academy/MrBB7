using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MacrotisExamDb.Models;
using MacrotisExamDb.Services;
using Microsoft.AspNetCore.Mvc;

namespace MacrotisExamDb.Controllers
{
    public class AttractionsController : Controller
    {
        IService attractionsDatabase;

        public AttractionsController(IService attractionsDatabase)
        {
            this.attractionsDatabase = attractionsDatabase;
        }

        [HttpGet("/")]
        public IActionResult List()
        {
            return View(attractionsDatabase.GetAllAttractions());
        }

        [HttpPost("add")]
        public IActionResult AddAttraction(Attractions attraction)
        {
            attractionsDatabase.AddAttraction(attraction);
            return View("List", attractionsDatabase.GetAllAttractions());
        }

        [HttpGet("edit/{id}")]
        public IActionResult GetAnAttraction(int id)
        {
            if (attractionsDatabase.GetAnAttraction(id) == null)
            {
                return RedirectToAction("List");
            }
            return View("UpdateAttraction", attractionsDatabase.GetAnAttraction(id));
        }

        [HttpPost("edit/{id}")]
        public IActionResult UpdateAttraction(Attractions attraction, int id)
        {
            attractionsDatabase.UpdateAttraction(attraction);
            return RedirectToAction("List");
        }

        [HttpGet("filter")]
        public IActionResult GetAllAttractions(string city, string category)
        {
            return Json(new
            {attractions =
                attractionsDatabase.GetAttractionsByCityAndCategory(city, category)
            });
        }
    }
}