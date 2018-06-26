using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public string Animal { get; set; }
        public bool IsKing { get; set; }

        public BankAccount()
        {
        }

        public BankAccount(int id, string name, int balance, string animal, bool isKing)
        {
            Id = id;
            Name = name;
            Balance = balance;
            Animal = animal;
            IsKing = isKing;
        }
    }
}
