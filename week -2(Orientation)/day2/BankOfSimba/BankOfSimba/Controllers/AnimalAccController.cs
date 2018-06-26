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
                Animal = "Lion"

            };
            return View(bankAccount);
        }

        public IActionResult Accounts()
        {
            AccountsInTheBank accountsInTheBank = new AccountsInTheBank();

            return View(accountsInTheBank);
        }
    }
}