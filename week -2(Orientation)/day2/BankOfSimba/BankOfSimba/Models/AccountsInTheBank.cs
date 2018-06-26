using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class AccountsInTheBank
    {
        public List<BankAccount> bankAccounts = new List<BankAccount>
        {
                new BankAccount(){Id = 1, Name = "Timon", Balance=8000, Animal= "Surikata", IsKing = true },
                new BankAccount(){Id = 2, Name = "Pumba", Balance=20000, Animal= "Warthog", IsKing = true },
                new BankAccount(){Id = 3, Name = "Mufasa", Balance=1400, Animal= "Lion", IsKing = false },
                new BankAccount(){Id = 4, Name = "Zordon", Balance=800, Animal= "Lion", IsKing = false }
        };
    }
}
