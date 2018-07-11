using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    [Route("[controller]")]
    public class FoxController : Controller
    {
        IFox foxClub;

        public FoxController(IFox foxClub)
        {
            this.foxClub = foxClub;
        }

        [HttpGet]
        [Route("NutritionStore")]
        public IActionResult NutritionStore()
        {
            return View();
        }

        [HttpPost]
        [Route("NutritionStore")]
        public IActionResult GetNutrition(string drink, string food)
        {
            foxClub.SetDrink(drink);
            foxClub.SetFood(food);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("TrickCenter")]
        public IActionResult TrickCenter()
        {
            return View();
        }

        [HttpPost]
        [Route("TrickCenter")]
        public IActionResult GetTrick(string trick)
        {
            foxClub.SetTricks(trick);

            return RedirectToAction("Index", "Home");
        }
    }
}
