using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal firstAnimal = new Animal();
            Console.WriteLine("Hunger level of the animal is: " + firstAnimal.Eat() +"\n" + "Thirst level of the animal is: " + firstAnimal.Drink());
            foreach (var item in firstAnimal.Play())
            {
                Console.WriteLine("Hunger and thirst level after play: " + item);
            }
            Console.ReadLine();
        }
    }
}

