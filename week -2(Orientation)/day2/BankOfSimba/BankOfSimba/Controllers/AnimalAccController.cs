using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class AnimalAccController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Simba()
        {
            var bankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion"

            };
            return View(bankAccount);
        }

        public IActionResult Accounts()
        {
            AccountsInTheBank accountsInTheBank = new AccountsInTheBank();

            return View(accountsInTheBank);
        }

        [HttpPost]
        [Route("changinbalance")]
        public IActionResult ChangingBalance(string type)
        {
            accountsInTheBank.AccountsInTheBank(type);

            return RedirectToAction("Accounts");
        }

        [HttpPost]
        [Route("AddNewAccount")]
        public IActionResult AddNewAccount(BankAccount account)
        {
            accountsInTheBank.AccountsInTheBank.Add(account);

            return RedirectToAction("Accounts");
        }
    }
}
}