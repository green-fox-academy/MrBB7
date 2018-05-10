using System;

namespace ConsoleApp8
{
    class thirdblocktask11new
    {
        static void Main(string[] args)
        {
            int a = 3;
            // make it bigger by 10
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            // please double c's value
            c += c;
            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            // please cube of e's value
            Console.WriteLine(e * e *e);

            int f1 = 123;
            int f2 = 345;
            bool bigger = true;
            bool smaller = false;
            // tell if f1 is bigger than f2 (print as a boolean)
            if (f1 > f2)
            {
                Console.WriteLine(bigger);
            }
            else
            {
                Console.WriteLine(smaller);
            }

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            bool indeedBigger = true;
            bool noitsnot = false;
            if ((g2 * 2) > g1)
            {
                Console.WriteLine(indeedBigger);
            }
            else
            {
                Console.WriteLine(noitsnot);
            }

            long h = 1357988018575474;
            int leftover = 0;
            // tell if it has 11 as a divisor (print as a boolean)
            bool elevendivides = true;
            bool nomrelevenesnohere = false;
            if (h % 11 == leftover)
            {
                Console.WriteLine(elevendivides);
            }
            else
            {
                Console.WriteLine(nomrelevenesnohere);
            }


            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            bool greater = true;
            bool notenough = false;
            if (i1 > (i2 * i2) && i1 < (i2 * i2 * i2))
            {
                Console.WriteLine(greater);
            }
            else
            {
                Console.WriteLine(notenough);
            }


            int j = 1521;
            int divider1 = 3;
            int divider2 = 5;
            // tell if j is dividable by 3 or 5 (print as a boolean)
            bool dividable = true;
            bool notdividable = false;
                if (j % divider1=0 || j % divider2=0)
                {
                    Console.WriteLine(dividable);
                }
                else
                {
                    Console.WriteLine(notdividable);
                }


               string k = "Apple";
            //fill the k variable with its cotnent 4 times

              Console.WriteLine(k);

            Console.ReadLine();
        }
    }
}
