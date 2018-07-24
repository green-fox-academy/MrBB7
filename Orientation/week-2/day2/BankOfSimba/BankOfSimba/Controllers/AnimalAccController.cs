using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class AnimalAccController : Controller
    {
        static List<BankAccount> bankAccounts = new List<BankAccount>
        {
            new BankAccount("Simba", 2000, "Lion"),
            new BankAccount("Timon", 15100, "Zuricata"),
            new BankAccount("Pumba", 30000, "Pig"),
            new BankAccount("Nala", 2000, "Lioness"),
        };

        [Route("simba")]
        public IActionResult Simba()
        {
            return View(bankAccounts[0]);
        }

        [Route("bankAccounts")]
        public IActionResult BankAccounts()
        {

            bankAccounts[0].MakeKing();
            bankAccounts[3].MakeBad();

            return View(bankAccounts);
        }

        [HttpPost]
        [Route("changinbalance")]
        public IActionResult ChangingBalance(int index)
        {
            bankAccounts[index].RaiseBalance();
            return View("bankAccounts", bankAccounts);
        }

        [HttpGet]
        [Route("addAnimal")]
        public IActionResult AddAnimal()
        {
            return View("AddAnimal");
        }

        [HttpPost]
        [Route("addAnimal")]
        public IActionResult AddAnimal(string name, double balance, string animalType)
        {
            bankAccounts.Add(new BankAccount(name, balance, animalType));
            return RedirectToAction("bankAccounts", bankAccounts);
        }
    }
}
