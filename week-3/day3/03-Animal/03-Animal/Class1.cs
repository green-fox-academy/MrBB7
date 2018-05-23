using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Animal
    {
        public int levelOfHunger = 50;
        public int levelOfThirst = 50;
        public int[] thistAndHunger = { 50, 50 };


        public int Eat()
        {
            int eat = Int32.Parse(Console.ReadLine());
            levelOfHunger -= eat;
            return levelOfHunger;
        }
        public int Drink()
        {
            int drink = Int32.Parse(Console.ReadLine());
            levelOfThirst -= drink;
            return levelOfThirst;
        }
        public int[] Play()
        {
            int play = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < thistAndHunger.Length; i++)
            {
                thistAndHunger[i] += play;
            }
            return thistAndHunger;
        }
    }
}