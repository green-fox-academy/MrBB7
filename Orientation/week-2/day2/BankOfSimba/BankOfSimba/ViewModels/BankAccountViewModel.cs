using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class BankAccountViewModel
    {
        public List<BankAccount> BankAccountDatabase { get; set; }

        public void AnimalChecker(string type)
        {
            foreach (var animal in BankAccountDatabase)
            {
                animal.ChangingBalance(type);
            }
        }
    }
}
