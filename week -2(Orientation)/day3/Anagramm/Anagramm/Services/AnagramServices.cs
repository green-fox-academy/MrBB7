using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    public class AnagramServices : IAnagram
    {
        private bool isAnagram;
        private string anagram;

        public void AnagramChecker(string inputWord)
        {
            char[] temp = inputWord.ToCharArray();
            Array.Reverse(temp);
            anagram = string.Join("", temp);

            isAnagram = inputWord.ToLower().Equals(anagram.ToLower());
        }

        public bool IsAnagram()
        {
            return isAnagram;
        }
    }
}
