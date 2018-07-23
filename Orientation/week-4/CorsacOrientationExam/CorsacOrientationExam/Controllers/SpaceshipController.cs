using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorsacOrientationExam.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorsacOrientationExam.Controllers
{
    public class SpaceshipController : Controller
    {
        private IService spaceService;

        public SpaceshipController(IService spaceService)
        {
            this.spaceService = spaceService;
        }

        [HttpGet("/")]
        public IActionResult SpaceTable()
        {
            return View(spaceService.GetAllSpaceEntities());
        }

        [HttpPost("movehere/{id}")]
        public IActionResult Movehere(int id)
        {
            spaceService.MoveSpaceShipToPlanetById(id);
            return RedirectToAction("SpaceTable");
        }

        [HttpGet("/toship/{id}")]
        public IActionResult PeopleToShip(int id)
        {
            spaceService.MovePeopleToShip(id);

            return RedirectToAction("SpaceTable");
        }

        [HttpGet("/toship/{id}")]
        public IActionResult PeopleToPlanet(int id)
        {
            spaceService.MovePeopleToplanet(id);

            return RedirectToAction("SpaceTable");
        }
    }
}