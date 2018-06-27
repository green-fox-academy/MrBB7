using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagramm.Services;
using Microsoft.AspNetCore.Mvc;

namespace Anagramm.Controllers
{
    [Route("/")]
    public class AnagrammController : Controller
    {
        private IAnagram anagram;

        public AnagrammController(IAnagram anagram)
        {
            this.anagram = anagram;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult AnagramChecker(string inputWord)
        {
            anagram.AnagramChecker(inputWord);
            return RedirectToAction("result");
        }

        [HttpGet]
        [Route("anagram")]
        public IActionResult Result()
        {
            return View("result", anagram.IsAnagram());
        }
    }
}