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
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsGoodBoi { get; set; }

        public BankAccount()
        {
        }

        public BankAccount(int id, string name, int balance, string animal, bool isKing)
        {
            Id = id;
            Name = name;
            Balance = balance;
            AnimalType = animal;
            IsKing = isKing;
        }

        public void ChangingBalance(string type)
        {
            if (type.ToLower().Equals(AnimalType.ToLower()))
            {
                if (IsKing)
                {
                    Balance += 100;
                }
                else
                {
                    Balance += 10;
                }
            }
        }
    }
}
