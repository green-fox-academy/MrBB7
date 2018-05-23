using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class Counter
    {
        public int sum;

        public Counter()
        {
            sum = 0;
        }
        public int Add(int number)
        {
            sum += number;
            return sum;
        }
        public void Add()
        {
            sum++;
        }
        public string Get()
        {
            string currentSum = sum.ToString();
            return currentSum;
        }
        public void Reset()
        {
            sum = 0;
        }
    }
}
