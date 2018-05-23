using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postitOne = new PostIt("Orange", "Blue", "Idea 1");
            PostIt postitTwo = new PostIt("Pink", "Black", "Awesome");
            PostIt postitThree = new PostIt("Yellow", "Green", "Superb!");

            Console.WriteLine(postitOne.BackgroundColor + " " + postitOne.TextColor + " " + postitOne.Text);

            Console.ReadLine();
        }
    }
}