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
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsGoodBoi { get; set; }

        public BankAccount()
        {
        }

        public BankAccount(string name, double balance, string animalType)
        {
            IsKing = false;
            IsGoodBoi = true;
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }

        public void MakeKing()
        {
            IsKing = true;
        }

        public void MakeBad()
        {
            IsGoodBoi = false;
        }

        public void RaiseBalance()
        {
            Balance += IsKing ? 100 : 10;
        }
    }
}
