using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatrixCheckerRefactor.Services;
using Microsoft.AspNetCore.Mvc;

namespace MatrixCheckerRefactor.Controllers
{
    public class MatrixController : Controller
    {

        private IService matrixService;

        public MatrixController(IService matrixService)
        {
            this.matrixService = matrixService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/matrix")]
        public IActionResult CheckTheMatrix(string inputMatrix)
        {
            return View("Index", matrixService.MatrixChecker(inputMatrix));
        }

        [HttpGet("/matrices")]
        public IActionResult ListOfMatrices()
        {
            return Json(matrixService.GetAllMatrices());
        }
    }
}