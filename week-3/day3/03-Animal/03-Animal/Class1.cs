using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Animal
    {
        public static int levelOfHunger = 50;
        public static int levelOfThirst = 50;
        public int[] thirstAndHunger = { levelOfThirst, levelOfHunger };


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
            for (int i = 0; i < thirstAndHunger.Length; i++)
            {
                thirstAndHunger[i] += play;
            }
            return thirstAndHunger;
        }
    }
}
