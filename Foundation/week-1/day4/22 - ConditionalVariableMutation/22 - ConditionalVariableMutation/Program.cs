using System;

namespace _22___ConditionalVariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            //if a is even increment out by one
            double a = 24;
            int output = 0;
            if (a % 2 == 0) { output++; }
            {
                Console.WriteLine(output);
            }
            

            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"
            int b = 13;
            string out2 = "";

            b = Int32.Parse(Console.ReadLine());

            if (b > 10 && b < 20 )
            {
                out2 = "sweet";
            }
            else if (b < 10)
            {
                out2 = "less!";
            }
            else if (b > 20)
            {
                out2 = "More!";
            }

            Console.WriteLine(out2);     
            
              int c = 123;
              int credits;
              bool isBonus = false;
            Console.Write("Give me the credits number: ");
            credits = Int32.Parse(Console.ReadLine());
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            if (credits >= 50 && isBonus == false)
            {
                c = c - 2;
            }
            else if(credits < 50 && isBonus ==false)
            {
                c = c - 1;
            }
            else if (isBonus= true)
            {
                Console.WriteLine(c);
            }

              Console.WriteLine(c);     

              int d = 8;
              int time;
              string out3 = "";
            Console.Write("Give me the time: ");
            time = Int32.Parse(Console.ReadLine());
            if (d % 4 == 0 && time <200) 
            {
                out3 = "check";
            }
            else if (time > 200)
            {
                out3 = "time out";
            }
            else
            {
                out3 = "Run Forest Run!";
            }
              // if d is dividable by 4
              // and time is not more than 200
              // set out3 to "check"
              // if time is more than 200
              // set out3 to "Time out"
              // otherwise set out3 to "Run Forest Run!"

              Console.WriteLine(out3); 
            Console.ReadLine();
        }
    }
}
